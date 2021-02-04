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
                OpenFavTeamForm();
				}
				else
				{                
                SetCulture(DEFAULT_LANGUAGE);            
                InitializeComponent();
				}
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
            var settings = new StringBuilder();

            settings.Append(rbHrv.Checked ? "Lang:HRV\n" : "Lang:ENG\n");
            settings.Append(rbMale.Checked ? "MaleFemale:M\n" : "MaleFemale:M\nF");

            Repo.CreateSettingsFile();
            Repo.SaveSettingsToFile(settings.ToString());

            OpenFavTeamForm();
        }
    }
}
