using DataLayer;
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
            Text = Text + " - " + fifaCode;
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
                MessageBox.Show(Properties.Resources.error);
				}


            List<Player> players = DataFlow.GetPlayersFromMatch(firstMatch, fifaCode);
            List<string> favPlayers = CheckForFavPlayers(players);
            players = players.Where(p => !favPlayers.Contains(p.Name)).ToList();
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

		  private List<string> CheckForFavPlayers(List<Player> plyrs)
		  {
            List<string> favPlayers = Repo.LoadFavPlayers();
				try
				{
					 if (favPlayers.Count > 0)
					 {
						  favPlayers.ForEach(fp =>
						  {
								flpFavouritePlayers.Controls.Add(
										  new PlayerUserControl(plyrs.Single(p => p.Name == fp))
										  {
												ContextMenuStrip = cmsFavourite,
												FavouriteIconVisible = true
										  });
						  });
					 }
				}
				catch (Exception)
				{
				}

            return favPlayers;				
		  }

		  private void BtnSaveFavouritePlayers_Click(object sender, EventArgs e)
        {
            string[] favPlayers = new string[3];
            List<PlayerUserControl> plyrs = flpFavouritePlayers.Controls.OfType<PlayerUserControl>().ToList();
            int i = 0;
            foreach (var p in plyrs)
            {   
                favPlayers[i++] = p.Player.Name;
            }
            Repo.SaveFavouritePlayers(favPlayers);

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

		  private void ChangeCompetitionOrLanguage(object sender, EventArgs e)
		  {
				MessageBoxButtons btns = MessageBoxButtons.YesNo;
				DialogResult result = MessageBox.Show(Properties.Resources.changeSettings, Properties.Resources.warning, btns);
				if (result == DialogResult.Yes)
				{
					 Repo.SaveSettingsToFile("", "MF");
					 Repo.SaveSettingsToFile("", "FavTeam");
					 InitialSettings init = new InitialSettings();
					 init.Show();
					 this.Hide();
				}
		  }

		  private void ChangeFavouriteTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(Properties.Resources.changeSettings, Properties.Resources.warning, btns);
            if (result == DialogResult.Yes)
            {
                Repo.SaveSettingsToFile("", "FavTeam");
                FavouriteTeam favouriteTeam = new FavouriteTeam();
                favouriteTeam.Show();
                this.Hide();
            }
        }

		  private void FavouritePlayers_FormClosing(object sender, FormClosingEventArgs e)
		  {
            if (MessageBox.Show(Properties.Resources.exitApp, Properties.Resources.warning, MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
                e.Cancel = true;
        }
	 }
}