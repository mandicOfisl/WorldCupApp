using DataLayer;
using System;
using System.Windows.Forms;

namespace WindowsForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

				if (Repo.CheckForSettingsFile())
				{
					 try
					 {
						  string fifaCode = Repo.LoadFavTeamSetting();
						  char maleFemale = Repo.LoadCompetitionSetting();

						  if (fifaCode != "")
						  {
								FavouritePlayers favouritePlayers = new FavouritePlayers(fifaCode, maleFemale);
								//favouritePlayers.ShowDialog();
								Application.Run(favouritePlayers);

								favouritePlayers.Dispose();
						  }
						  else
						  {
								FavouriteTeam ft = new FavouriteTeam();
								Application.Run(ft);
								ft.Dispose();
						  }
					 }
					 catch (Exception)
					 {
						  InitialSettings initSett = new InitialSettings();
						  Application.Run(initSett);
						  initSett.Dispose();
					 }

                //Application.Run(new FavouriteTeam());
				}
				else
				{
                InitialSettings initSett = new InitialSettings();
                Application.Run(initSett);
                initSett.Dispose();

            }

        }
    }
}
