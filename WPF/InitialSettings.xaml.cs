using DataLayer;
using System.Windows;

namespace WPF
{
    public partial class InitialSettings : Window
    {
		  private bool closedOnButton = true;
        public InitialSettings()
        {
				InitializeComponent();
				this.DataContext = new InitSettingsVM();				
        }

		  private void BtnSave_Click(object sender, RoutedEventArgs e)
		  {
				MessageBoxResult res = MessageBox.Show(
						  Properties.Resources.SaveSettings,
						  Properties.Resources.Warning,
						  MessageBoxButton.YesNoCancel);

				if (res == MessageBoxResult.Yes)
				{
					 InitSettingsVM set = DataContext as InitSettingsVM;

					 Repo.SaveSettingsToFile(set.Hrv ? "hr" : "en", "Lang");
					 Repo.SaveSettingsToFile(set.MaleCompetition ? "m" : "f", "MaleFemale");

					 string screenSize;

					 if (set.SmallScreen)
					 {
						  screenSize = "s";
					 }
					 else if (set.Fullscreen)
					 {
						  screenSize = "l";
					 }
					 else
					 {
						  screenSize = "m";
					 }

					 Repo.SaveSettingsToFile(screenSize, "Screen");

					 FavouriteTeam ft = new FavouriteTeam();
					 ft.Show();
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
