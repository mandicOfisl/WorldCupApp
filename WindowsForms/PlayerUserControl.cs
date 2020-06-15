using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Models;

namespace WindowsForms
{
    public partial class PlayerUserControl : UserControl
    {
        
        private PlayerUserControl selectedPlayer = null;
        public Player Player { get; set; }
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
            lblCaptain.Visible = player.Captain ? true : false;
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

        internal void ToggleFavourite()
        {
           FavouriteIconVisible = !FavouriteIconVisible;
        }

        private void addToFavouritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
