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
            SetCulture(DEFAULT_LANGUAGE);
            InitializeComponent();
        }
		  private void SetCulture(string culture)
		  {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);
        }
		  private void BtnSaveInitSettings_Click(object sender, EventArgs e)
        {
            Repo.SaveSettingsToFile(rbHrv.Checked ? "hr" : "en", "Lang");
            Repo.SaveSettingsToFile(rbMale.Checked ? "m" : "f", "MF");

            OpenFavTeamForm();
        }

		  private void OpenFavTeamForm()
		  {
            FavouriteTeam favouriteTeam = new FavouriteTeam();
            favouriteTeam.Show();
            Hide();
        }

		  private void InitialSettings_FormClosing(object sender, FormClosingEventArgs e)
		  {
            if (MessageBox.Show("Exit application?", "Warning", MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
                e.Cancel = true;

        }
	 }
}
