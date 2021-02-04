using DataLayer;
using DataLayer.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPF
{
	 public partial class FavouriteTeam : Window
	 {
		  public List<DataLayer.Team> Teams { get; set; }
		  public List<Match> FirstMatches { get; set; }
		  public List<Match> SecondMatches { get; set; }
		  public FavouriteTeam()
		  {
				InitializeComponent();
				PopulateComboBox();
		  }

		  private async void PopulateComboBox()
		  {
				LoadingWindow lw = new LoadingWindow();
				lw.Show();
				try
				{
					 Teams = await DataFlow.GetTeams("http://world-cup-json-2018.herokuapp.com/teams");
					 cbTeams.ItemsSource = Teams;
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
					 StringBuilder sb = new StringBuilder();
					 sb.Append(teamFirst.FifaCode);
					 sb.Append(";");
					 sb.Append(teamSecond.FifaCode);
					 Repo.SaveSettingsToFile(sb.ToString(), "teams.txt");

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
					 Score = score
				};
								
				StartingEleven se = new StartingEleven(model);
				se.Show();
				this.Hide();
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
				var url = "http://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=" + fifaCode;
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
				cbTeamsSecond.ItemsSource = (from t in Teams where opponents.Contains(t.FifaCode) select t);
		  }
		  private async void CbTeamsSecond_SelectionChanged(object sender, SelectionChangedEventArgs e)
		  {
				string secondTeamCode = (e.AddedItems[0] as DataLayer.Team).FifaCode;
				BtnSecondTeamInfo.IsEnabled = true;
				var url = "http://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=" + secondTeamCode;
				LoadingWindow lw = new LoadingWindow();
				lw.Show();
				SecondMatches = await DataFlow.GetMatches(url);
				lw.Close();
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

		  private void Window_Closed(object sender, System.EventArgs e) => Application.Current.Shutdown();
	 }
}
