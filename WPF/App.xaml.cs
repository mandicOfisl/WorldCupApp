using DataLayer;
using System.Windows;

namespace WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
	 {
		  private void Application_Startup(object sender, StartupEventArgs e)
		  {
				if (Repo.CheckForSettingsFile())
				{
					 if (Repo.LoadScreenSizeSetting() != "")
					 {
						  FavouriteTeam ft = new FavouriteTeam();
						  ft.Show();
					 }
					 else
					 {
						  InitialSettings init = new InitialSettings();
						  init.Show();
					 }					 
				}
				else
				{
					 InitialSettings init = new InitialSettings();
					 init.Show();
				}
		  }
	 }
}
