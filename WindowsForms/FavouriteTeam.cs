using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Properties;

namespace WindowsForms
{
    public partial class FavouriteTeam : Form
    {
        private string maleTeamsURL = "https://world-cup-json-2018.herokuapp.com/teams";
        private string femaleTeamsURL = "https://worldcup.sfg.io/teams";
        private static readonly string favouriteTeamPath = "favTeam.txt";
        private char maleFemale;

        public FavouriteTeam(string settings)
        {
            InitializeComponent();
            PopulateComboBox(settings);

            maleFemale = settings.Last<char>();
        }

        private async void PopulateComboBox(string settings)
        {
            var teams = await DataFlow.GetTeams(
                settings.EndsWith("M") ? maleTeamsURL : femaleTeamsURL);
            foreach (var team in teams)
            {
                cbTeamList.Items.Add(team.ToString());
            }
        }

        private void btnSaveFavouriteRep_Click(object sender, EventArgs e)
        {
            if (cbTeamList.SelectedIndex != -1)
            {
                Repo.SaveSettingsToFile(cbTeamList.SelectedItem.ToString(), favouriteTeamPath);
                string rep = cbTeamList.SelectedItem.ToString();
                string fifaCode = rep.Substring(rep.IndexOf('(') + 1, 3);
                FavouritePlayers favouritePlayers = new FavouritePlayers(fifaCode, maleFemale);
                favouritePlayers.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Pick your favourite team and click the 'Save' button to continue!");
            }
            
        }
    }
}
