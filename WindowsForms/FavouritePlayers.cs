using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace WindowsForms
{
    public partial class FavouritePlayers : Form
    {
        private string maleMatchesURL = "http://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";
        private string femaleMatchesURL = "http://worldcup.sfg.io/matches/country?fifa_code=";
        public FavouritePlayers(string fifaCode, char maleFemale)
        {
            InitializeComponent();
            FillAllPlayers(maleFemale, fifaCode);
        }

        private async void FillAllPlayers(char maleFemale, string fifaCode)
        {
            StringBuilder url = new StringBuilder();
            url.Append(maleFemale == 'M' ? maleMatchesURL : femaleMatchesURL);
            url.Append(fifaCode);

            var matches = await DataFlow.GetPlayers(url.ToString());
            Match firstMatch = matches.First<Match>();
            List<Player> players = GetPlayersFromMatch(firstMatch, fifaCode);
            foreach (var player in players)
            {
                flpAllPlayers.Controls.Add(
                    new PlayerUserControl(player)
                    //{
                    //    ContextMenuStrip = cmsNotFavourite
                    //});
                    );
            }
        }

        private List<Player> GetPlayersFromMatch(Match match, string fifaCode)
        {
            List<Player> players = new List<Player>();
            if (match.HomeTeam.Code == fifaCode)
            {
                foreach (var player in match.HomeTeamStatistics.StartingEleven)
                {
                    players.Add(player);
                }
                foreach (var player in match.HomeTeamStatistics.Substitutes)
                {
                    players.Add(player);
                }
            }
            else
            {
                foreach (var player in match.AwayTeamStatistics.StartingEleven)
                {
                    players.Add(player);
                }
                foreach (var player in match.AwayTeamStatistics.Substitutes)
                {
                    players.Add(player);
                }
            }
            return players;
        }

        private void btnSaveFavouritePlayers_Click(object sender, EventArgs e)
        {
            StringBuilder favPlayers = new StringBuilder();
            var plyrs = flpFavouritePlayers.Controls.OfType<PlayerUserControl>();
            foreach (var p in plyrs)
            {
                favPlayers.AppendLine(p.Name);
            }
            Repo.SaveSettingsToFile(favPlayers.ToString(), "favouritePlayers.txt");
        }

        private void flpFavouritePlayers_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void flpFavouritePlayers_DragDrop(object sender, DragEventArgs e)
        {
            var data = (PlayerUserControl)e.Data.GetData(typeof(PlayerUserControl));
            if (flpFavouritePlayers.Controls.Count < 3)
            {
                PlayerUserControl plyr = data;
                plyr.ToggleFavourite();
                //plyr.ContextMenuStrip = cmsFavourite;
                flpFavouritePlayers.Controls.Add(plyr);
            }
        }

        private void flpAllPlayers_DragDrop(object sender, DragEventArgs e)
        {
            var puc = (PlayerUserControl)e.Data.GetData(typeof(PlayerUserControl));
            if (puc.Parent != flpAllPlayers)
            {
                flpFavouritePlayers.Controls.Remove(puc);
                puc.ToggleFavourite();
                flpAllPlayers.Controls.Add(puc);
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}