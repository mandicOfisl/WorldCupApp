using DataLayer;
using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class InitialSettings : Form
    {
        private const string DEFAULT_LANGUAGE = "hr";
        public InitialSettings()
        {
				if (Repo.CheckForSettingsFile())
				{
					 if (Repo.LoadFavTeamSetting() != "")
					 {
                    OpenFavPlayersForm();
					 }
					 else
					 {
                    OpenFavTeamForm();
					 }					 
				}
				else
				{
                SetCulture(DEFAULT_LANGUAGE);            
                InitializeComponent();
				}				
        }

		  private void OpenFavPlayersForm()
		  {
            FavouritePlayers favouritePlayers = new FavouritePlayers(
                    Repo.LoadFavTeamSetting(),
                    Repo.LoadCompetitionSetting());
            favouritePlayers.Show();
            Hide();
		  }

		  private void OpenFavTeamForm()
		  {
            FavouriteTeam favouriteTeam = new FavouriteTeam();
            favouriteTeam.Show();
            Hide();
        }

		  private void SetCulture(string culture)
		  {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);
        }

		  private void BtnSaveInitSettings_Click(object sender, EventArgs e)
        {
            Repo.SaveSettingsToFile(rbHrv.Checked ? "hr" : "en", "Lang");
            Repo.SaveSettingsToFile(rbMale.Checked ? "M" : "F", "MaleFemale");

            OpenFavTeamForm();
        }
    }
}
