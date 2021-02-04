﻿using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FavouritePlayers : Form
    {
        public char Mf { get; set; }
		  public string FifaCode { get; set; }
		  public FavouritePlayers(string fifaCode, char maleFemale)
        {
            string culture = Repo.LoadLangSetting();
            SetCulture(culture);
            InitializeComponent();
            Mf = maleFemale;
            FifaCode = fifaCode;
            FillAllPlayers(Mf, FifaCode);
        }

		  public FavouritePlayers(string fifaCode, char mf, string culture)
		  {
            SetCulture(culture);
            InitializeComponent();
            Mf = mf;
				FifaCode = fifaCode;
            FillAllPlayers(Mf, FifaCode);
        }

		  private void SetCulture(string culture)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);
        }
        private async void FillAllPlayers(char maleFemale, string fifaCode)
        {
            StringBuilder url = new StringBuilder();
            url.Append(Repo.GetMatchesUrl(maleFemale));
            url.Append(fifaCode);
            Match firstMatch = new Match();

            LoadingWindow lw = new LoadingWindow();
            lw.Show();

				try
				{
					 var matches = await DataFlow.GetMatches(url.ToString());
					 firstMatch = matches.First<Match>();
				}
				catch (Exception)
				{
                MessageBox.Show("There has been an error. Please select another team");
				}


            List<Player> players = DataFlow.GetPlayersFromMatch(firstMatch, fifaCode);
            foreach (var player in players)
            {
                flpAllPlayers.Controls.Add(
                    new PlayerUserControl(player)
                    {
                        ContextMenuStrip = cmsFavourite
                    });
            }
            lw.Close();
        }
        private void BtnSaveFavouritePlayers_Click(object sender, EventArgs e)
        {
            StringBuilder favPlayers = new StringBuilder();
            var plyrs = flpFavouritePlayers.Controls.OfType<PlayerUserControl>();
            foreach (var p in plyrs)
            {
                favPlayers.AppendLine(p.Player.Name);
            }
            Repo.SaveSettingsToFile(favPlayers.ToString());

            Rankings rankings = new Rankings();
            rankings.Show();
            this.Hide();
        }
        private void FlpFavouritePlayers_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void FlpFavouritePlayers_DragDrop(object sender, DragEventArgs e)
        {
            var data = (PlayerUserControl)e.Data.GetData(typeof(PlayerUserControl));
            if (flpFavouritePlayers.Controls.Count < 3 || data.Parent != flpAllPlayers)
            {
                PlayerUserControl plyr = data;
                //plyr.ToggleFavourite();
                plyr.FavouriteIconVisible = true;
                //plyr.ContextMenuStrip = cmsFavourite;
                flpFavouritePlayers.Controls.Add(plyr);
            }
        }
        private void FlpAllPlayers_DragDrop(object sender, DragEventArgs e)
        {
            var puc = (PlayerUserControl)e.Data.GetData(typeof(PlayerUserControl));
            if (puc.Parent != flpAllPlayers)
            {
                flpFavouritePlayers.Controls.Remove(puc);
                puc.FavouriteIconVisible = false;
                flpAllPlayers.Controls.Add(puc);
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void AddOption_Click(object sender, EventArgs e)
        {
				if (sender is ToolStripItem stripItem)
				{
					 if (stripItem.Owner is ContextMenuStrip owner)
					 {
						  PlayerUserControl puc = (PlayerUserControl)owner.SourceControl;
						  if (flpFavouritePlayers.Controls.Count < 3)
						  {
								PlayerUserControl plyr = puc;
								plyr.FavouriteIconVisible = true;
								flpFavouritePlayers.Controls.Add(plyr);
						  }
					 }
				}
		  }
        private void RmvOption_Click(object sender, EventArgs e)
        {
				if (sender is ToolStripItem stripItem)
				{
					 if (stripItem.Owner is ContextMenuStrip owner)
					 {
						  PlayerUserControl puc = (PlayerUserControl)owner.SourceControl;
						  if (puc.Parent != flpAllPlayers)
						  {
								flpFavouritePlayers.Controls.Remove(puc);
								puc.FavouriteIconVisible = false;
								flpAllPlayers.Controls.Add(puc);
						  }
					 }
				}
		  }
        private void LoadOption_Click(object sender, EventArgs e)
        {
				if (sender is ToolStripItem stripItem)
				{
					 if (stripItem.Owner is ContextMenuStrip owner)
					 {
						  PlayerUserControl puc = (PlayerUserControl)owner.SourceControl;
						  var ofd = new OpenFileDialog
						  {
								Filter = "Slike|*.bmp;*.jpg;*.jpeg;*.png"
						  };
						  if (ofd.ShowDialog() == DialogResult.OK)
						  {
								puc.LoadImage(ofd.FileName, puc.Player.Name);
                        Repo.SaveImage(ofd.FileName, puc.Player.Name);
						  }
					 }
				}
		  }
        private void ChangeCompetitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you want to change the settings?", "!", btns);
            if (result == DialogResult.Yes)
            {
                InitialSettings init = new InitialSettings();
                init.Show();
                this.Hide();
            }
        }
        private void ChangeFavouriteTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you want to change the settings?", "!", btns);
            if (result == DialogResult.Yes)
            {
                FavouriteTeam favouriteTeam = new FavouriteTeam();
                favouriteTeam.Show();
                this.Hide();
            }
        }
        private void ChangeLanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string culture = Repo.LoadLangSetting() == "hr" ? "en" : "hr";
            FavouritePlayers fp = new FavouritePlayers(FifaCode, Mf, culture);
            fp.Show();
            Hide();
        }

		  private void FavouritePlayers_FormClosed(object sender, FormClosedEventArgs e)
		  {
            Application.Exit();
		  }
	 }
}