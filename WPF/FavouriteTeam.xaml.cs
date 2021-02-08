using DataLayer;
using DataLayer.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPF
{
	 public partial class FavouriteTeam : Window
	 {
		  private bool closedOnButton = true;
		  public List<DataLayer.Team> Teams { get; set; }
		  public List<Match> FirstMatches { get; set; }
		  public List<Match> SecondMatches { get; set; }

		  public FavouriteTeam()
		  {
				SetCulture(Repo.LoadLangSetting());
				InitializeComponent();
				PopulateComboBox();
		  }

		  private void SetCulture(string culture)
		  {
				Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
				Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);
		  }

		  private async void PopulateComboBox()
		  {
				LoadingWindow lw = new LoadingWindow();
				lw.Show();
				try
				{
					 Teams = await DataFlow.GetTeams(Repo.GetTeamsUrl(Repo.LoadCompetitionSetting()));
					 cbTeams.ItemsSource = Teams;

					 string favTeam = Repo.LoadFavTeamSetting();
					 if (favTeam != "")
					 {
						  cbTeams.SelectedValue = Teams.First(t => t.FifaCode == favTeam);
						  lw.Close();
					 }

				}
				catch (System.Exception)
				{
					 MessageBox.Show("There has been an error connecting to the server. Please try again later!");
					 Application.Current.Shutdown();
				}
				lw.Close();
		  }

		  private void BtnContinue_Click(object sender, RoutedEventArgs e)
		  {
				try
				{
					 var teamFirst = cbTeams.SelectedValue as DataLayer.Team;
					 var teamSecond = cbTeamsSecond.SelectedValue as DataLayer.Team;

					 CreateNewWindow(teamFirst, teamSecond);
				}
				catch (System.Exception)
				{
					 MessageBox.Show("Please select teams!");
				}
		  }

		  private void CreateNewWindow(DataLayer.Team teamFirst, DataLayer.Team teamSecond)
		  {
				Match match = 
					 (from m in FirstMatches 
					  where ((teamFirst.FifaCode == m.HomeTeam.Code && teamSecond.FifaCode == m.AwayTeam.Code)
					  || (teamFirst.FifaCode == m.AwayTeam.Code && teamSecond.FifaCode == m.HomeTeam.Code))
					  select m).First();

				string score = Repo.GetScoreFromMatch(match);

				DataLayer.Team homeTeam = teamFirst.FifaCode == match.HomeTeam.Code ? teamFirst : teamSecond;
				DataLayer.Team awayTeam = homeTeam == teamFirst ? teamSecond : teamFirst;

				StartingElevenVM model = new StartingElevenVM
				{
					 HomeStartEleven = match.HomeTeamStatistics.StartingEleven,
					 AwayStartEleven = match.AwayTeamStatistics.StartingEleven,
					 HomeTeam = homeTeam,
					 AwayTeam = awayTeam,
					 Score = score,
					 Match = match
				};
								
				StartingEleven se = new StartingEleven(model);
				se.Show();
				closedOnButton = false;
				this.Close();
		  }

		  private async void CbTeamsFirst_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
		  {
				var firstTeam = e.AddedItems[0] as DataLayer.Team;
				BtnFirstTeamInfo.IsEnabled = true;
				LoadingWindow lw = new LoadingWindow();
				lw.Show();
				await PopulateSecondComboBoxAsync(firstTeam.FifaCode);
				lw.Close();
		  }

		  private async Task PopulateSecondComboBoxAsync(string fifaCode)
		  {
				var url = Repo.GetMatchesUrl(Repo.LoadCompetitionSetting()) + fifaCode;
				FirstMatches = await DataFlow.GetMatches(url);
				HashSet<string> opponents = new HashSet<string>();
				foreach (var match in FirstMatches)
				{
					 if (!match.HomeTeam.Code.Equals(fifaCode))
					 {
						  opponents.Add(match.HomeTeam.Code);
					 }
					 else
					 {
						  opponents.Add(match.AwayTeam.Code);
					 }
				}
				cbTeamsSecond.ItemsSource = null;
				cbTeamsSecond.ItemsSource = (from t in Teams where opponents.Contains(t.FifaCode) select t);
		  }
		  private async void CbTeamsSecond_SelectionChanged(object sender, SelectionChangedEventArgs e)
		  {
				if (e.AddedItems.Count > 0)
				{
					 string secondTeamCode = (e.AddedItems[0] as DataLayer.Team).FifaCode;
					 BtnSecondTeamInfo.IsEnabled = true;
					 var url = Repo.GetMatchesUrl(Repo.LoadCompetitionSetting()) + secondTeamCode;
					 LoadingWindow lw = new LoadingWindow();
					 lw.Show();
					 SecondMatches = await DataFlow.GetMatches(url);
					 lw.Close();
				}
		  }

		  private void BtnTeamInfo_Click(object sender, RoutedEventArgs e)
		  {
				var btn = sender as Button;
				DataLayer.Team team = new DataLayer.Team();
				List<Match> matches = new List<Match>();
				switch (btn.Name)
				{
					 case "BtnFirstTeamInfo":
						  team = cbTeams.SelectedValue as DataLayer.Team;
						  matches = FirstMatches;
						  break;
					 case "BtnSecondTeamInfo":
						  team = cbTeamsSecond.SelectedValue as DataLayer.Team;
						  matches = SecondMatches;
						  break;
					 default:
						  break;
				}
				TeamInfoVM model = new TeamInfoVM
				{
					 Name = team.Country,
					 FifaCode = team.FifaCode,
					 Matches = Repo.CountTeamMatchStats(team.FifaCode, matches),
					 Goals = Repo.CountTeamGoalsStats(team.FifaCode, matches)
				};

				new TeamInfo(model).Show();
		  }
		  
		  private void BtnSettings_Click(object sender, RoutedEventArgs e)
		  {
				MessageBoxResult res = MessageBox.Show(
								Properties.Resources.ChangeSettings, 
								Properties.Resources.Warning, 
								MessageBoxButton.YesNoCancel);
				if (res == MessageBoxResult.Yes)
				{
					 InitialSettings init = new InitialSettings();
					 init.Show();
					 closedOnButton = false;
					 this.Close();
				}
		  }

		  private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		  {
				if (closedOnButton)
				{
					 MessageBoxResult res = MessageBox.Show(
									 Properties.Resources.ExitApp,
									 Properties.Resources.Warning,
									 MessageBoxButton.YesNoCancel);
					 if (res == MessageBoxResult.Yes)
					 {
						  Application.Current.Shutdown();
					 }
					 else e.Cancel = true;
				}
		  }
	 }
}
