using DataLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
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
					 FavouriteTeam ft = new FavouriteTeam();
					 ft.Show();
				}
				else
				{
					 InitialSettings init = new InitialSettings();
					 init.Show();
				}
		  }
	 }
}
