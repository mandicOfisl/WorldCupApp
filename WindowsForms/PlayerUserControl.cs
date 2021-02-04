using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DataLayer.Models;
using System.IO;

namespace WindowsForms
{
    public partial class PlayerUserControl : UserControl
    {
        
        private PlayerUserControl selectedPlayer = null;
        public Player Player { get; set; }
		  public string ImagePath { get; set; }
		  public bool FavouriteIconVisible 
        {
            get
            {
                return pbFavourite.Visible;
            }
            set 
            {
                pbFavourite.Visible = value;
            } 
        }
        public PlayerUserControl(Player player)
        {
            Player = player;
            InitializeComponent();
            
            InitData(Player);
        }

        private void InitData(Player player)
        {
            lblNameAndNumber.Text = $"#{player.ShirtNumber} {player.Name}";
            lblPosition.Text = player.Position.ToString();
            lblCaptain.Visible = player.Captain;
            CheckSavedImages(player.Name);
				if (ImagePath != null)
				{
                pbImage.Image = Image.FromFile(ImagePath);
				}
        }

		  private void CheckSavedImages(string name)
		  {
            string dir = Path.Combine(
                    Path.GetDirectoryName(
                        Path.GetDirectoryName(
                            Directory.GetCurrentDirectory())) + @"\img", name + ".png");
            ImagePath = File.Exists(dir) ? dir : null;
		  }

		  private void PlayerUserControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PlayerUserControl puc = sender as PlayerUserControl;
                SelectPlayer(puc);

                puc.DoDragDrop(puc, DragDropEffects.Move);
            }
        }

        private void SelectPlayer(PlayerUserControl puc)
        {
            var allPlayers = Parent.Controls.OfType<PlayerUserControl>();
            foreach (var p in allPlayers)
            {
                p.BackColor = Color.Gray;
            }
            selectedPlayer = puc;
            selectedPlayer.BackColor = Color.White;
        }

        internal void LoadImage(string fileName, string playerName)
        {
            Image img = Image.FromFile(fileName);
            pbImage.Image = img;
        }
    }
}
