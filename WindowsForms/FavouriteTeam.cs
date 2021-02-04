using DataLayer;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FavouriteTeam : Form
    {
        private readonly char maleFemale;

        public FavouriteTeam()
        {
            SetCulture(Repo.LoadLangSetting());
            maleFemale = Repo.LoadCompetitionSetting();
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
            var teams = await DataFlow.GetTeams(Repo.GetTeamsUrl(maleFemale));
            foreach (var team in teams)
            {
                cbTeamList.Items.Add(team.ToString());
            }
            lw.Close();
        }

        private void BtnSaveFavouriteRep_Click(object sender, EventArgs e)
        {
            if (cbTeamList.SelectedIndex != -1)
            {
                string rep = cbTeamList.SelectedItem.ToString();
                string fifaCode = rep.Substring(rep.IndexOf('(') + 1, 3);
                Repo.SaveSettingsToFile("FavTeam:" + fifaCode + "\n");
                FavouritePlayers favouritePlayers = new FavouritePlayers(fifaCode, maleFemale);
                favouritePlayers.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(Properties.Resources.favTeamError);
            }            
        }

		  private void FavouriteTeam_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
		  
	 }
}
