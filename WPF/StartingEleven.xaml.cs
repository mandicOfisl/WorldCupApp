using DataLayer;
using DataLayer.Models;
using System.Collections.Generic;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace WPF
{
	 public partial class StartingEleven : Window
	 {
		  private bool closedOnButton = true;
		  public StartingEleven(StartingElevenVM model)
		  {
				SetCulture(Repo.LoadLangSetting());
				SetSize();
				InitializeComponent();
				this.DataContext = model;

				CreateFields(model.HomeStartEleven, model.AwayStartEleven, model.Match);
		  }

		  private void SetSize()
		  {
				switch (Repo.LoadScreenSizeSetting())
				{
					 case "s":
						  Height = 500;
						  Width = 1000;
						  break;
					 case "m":
						  Height = 600;
						  Width = 1200;
						  break;
					 case "l":
						  WindowState = WindowState.Maximized;
						  break;
					 default:
						  break;
				}
		  }

		  private void SetCulture(string culture)
		  {
				Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
				Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);
		  }

		  private void CreateFields(List<Player> homeTeam, List<Player> awayTeam, Match match)
		  {
				PitchUC homePitch = new PitchUC(homeTeam, match);
				PitchUC awayPitch = new PitchUC(awayTeam, match);

				Grid.SetRow(homePitch, 1);
				Grid.SetColumn(homePitch, 0);

				Grid.SetRow(awayPitch, 1);
				Grid.SetColumn(awayPitch, 2);

				grid.Children.Add(homePitch);
				grid.Children.Add(awayPitch);

		  }
		  
		  private void BtnSettings_Click(object sender, RoutedEventArgs e)
		  {
				MessageBoxResult res = MessageBox.Show(
								Properties.Resources.ChangeSettings,
								Properties.Resources.Warning,
								MessageBoxButton.YesNo);
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
