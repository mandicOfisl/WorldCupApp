namespace WindowsForms
{
    partial class FavouritePlayers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmsFavourite = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPictureToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsNotFavourite = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFavouritePlayers = new System.Windows.Forms.Label();
            this.lblAllPlayers = new System.Windows.Forms.Label();
            this.flpFavouritePlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.flpAllPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSaveFavouritePlayers = new System.Windows.Forms.Button();
            this.cmsFavourite.SuspendLayout();
            this.cmsNotFavourite.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsFavourite
            // 
            this.cmsFavourite.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removePlayerToolStripMenuItem,
            this.loadPictureToolStripMenuItem1});
            this.cmsFavourite.Name = "cmsFavourite";
            this.cmsFavourite.Size = new System.Drawing.Size(181, 70);
            // 
            // removePlayerToolStripMenuItem
            // 
            this.removePlayerToolStripMenuItem.Name = "removePlayerToolStripMenuItem";
            this.removePlayerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removePlayerToolStripMenuItem.Text = "Remove player";
            this.removePlayerToolStripMenuItem.Click += new System.EventHandler(this.removePlayerToolStripMenuItem_Click);
            // 
            // loadPictureToolStripMenuItem1
            // 
            this.loadPictureToolStripMenuItem1.Name = "loadPictureToolStripMenuItem1";
            this.loadPictureToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.loadPictureToolStripMenuItem1.Text = "Load picture";
            // 
            // cmsNotFavourite
            // 
            this.cmsNotFavourite.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToFavouritesToolStripMenuItem,
            this.loadPictureToolStripMenuItem});
            this.cmsNotFavourite.Name = "cmsNotFavourite";
            this.cmsNotFavourite.Size = new System.Drawing.Size(166, 48);
            // 
            // addToFavouritesToolStripMenuItem
            // 
            this.addToFavouritesToolStripMenuItem.Name = "addToFavouritesToolStripMenuItem";
            this.addToFavouritesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addToFavouritesToolStripMenuItem.Text = "Add to favourites";
            // 
            // loadPictureToolStripMenuItem
            // 
            this.loadPictureToolStripMenuItem.Name = "loadPictureToolStripMenuItem";
            this.loadPictureToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.loadPictureToolStripMenuItem.Text = "Load picture";
            // 
            // lblFavouritePlayers
            // 
            this.lblFavouritePlayers.AutoSize = true;
            this.lblFavouritePlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavouritePlayers.Location = new System.Drawing.Point(81, 29);
            this.lblFavouritePlayers.Name = "lblFavouritePlayers";
            this.lblFavouritePlayers.Size = new System.Drawing.Size(137, 20);
            this.lblFavouritePlayers.TabIndex = 4;
            this.lblFavouritePlayers.Text = "3 favourite players";
            // 
            // lblAllPlayers
            // 
            this.lblAllPlayers.AutoSize = true;
            this.lblAllPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllPlayers.Location = new System.Drawing.Point(662, 29);
            this.lblAllPlayers.Name = "lblAllPlayers";
            this.lblAllPlayers.Size = new System.Drawing.Size(80, 20);
            this.lblAllPlayers.TabIndex = 5;
            this.lblAllPlayers.Text = "All players";
            // 
            // flpFavouritePlayers
            // 
            this.flpFavouritePlayers.AllowDrop = true;
            this.flpFavouritePlayers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpFavouritePlayers.Location = new System.Drawing.Point(23, 72);
            this.flpFavouritePlayers.Name = "flpFavouritePlayers";
            this.flpFavouritePlayers.Size = new System.Drawing.Size(260, 780);
            this.flpFavouritePlayers.TabIndex = 9;
            this.flpFavouritePlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpFavouritePlayers_DragDrop);
            this.flpFavouritePlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpFavouritePlayers_DragEnter);
            // 
            // flpAllPlayers
            // 
            this.flpAllPlayers.AllowDrop = true;
            this.flpAllPlayers.AutoScroll = true;
            this.flpAllPlayers.Location = new System.Drawing.Point(318, 72);
            this.flpAllPlayers.Margin = new System.Windows.Forms.Padding(0);
            this.flpAllPlayers.Name = "flpAllPlayers";
            this.flpAllPlayers.Size = new System.Drawing.Size(780, 780);
            this.flpAllPlayers.TabIndex = 10;
            this.flpAllPlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpAllPlayers_DragDrop);
            this.flpAllPlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpFavouritePlayers_DragEnter);
            // 
            // btnSaveFavouritePlayers
            // 
            this.btnSaveFavouritePlayers.BackgroundImage = global::WindowsForms.Properties.Resources.Programming_Save_icon;
            this.btnSaveFavouritePlayers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveFavouritePlayers.Location = new System.Drawing.Point(529, 859);
            this.btnSaveFavouritePlayers.Name = "btnSaveFavouritePlayers";
            this.btnSaveFavouritePlayers.Size = new System.Drawing.Size(50, 50);
            this.btnSaveFavouritePlayers.TabIndex = 6;
            this.btnSaveFavouritePlayers.UseVisualStyleBackColor = true;
            this.btnSaveFavouritePlayers.Click += new System.EventHandler(this.btnSaveFavouritePlayers_Click);
            // 
            // FavouritePlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 921);
            this.Controls.Add(this.flpAllPlayers);
            this.Controls.Add(this.flpFavouritePlayers);
            this.Controls.Add(this.btnSaveFavouritePlayers);
            this.Controls.Add(this.lblAllPlayers);
            this.Controls.Add(this.lblFavouritePlayers);
            this.Name = "FavouritePlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Favourite players";
            this.cmsFavourite.ResumeLayout(false);
            this.cmsNotFavourite.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsFavourite;
        private System.Windows.Forms.ToolStripMenuItem removePlayerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsNotFavourite;
        private System.Windows.Forms.ToolStripMenuItem addToFavouritesToolStripMenuItem;
        private System.Windows.Forms.Label lblFavouritePlayers;
        private System.Windows.Forms.Label lblAllPlayers;
        private System.Windows.Forms.Button btnSaveFavouritePlayers;
        private System.Windows.Forms.FlowLayoutPanel flpFavouritePlayers;
        private System.Windows.Forms.FlowLayoutPanel flpAllPlayers;
        private System.Windows.Forms.ToolStripMenuItem loadPictureToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadPictureToolStripMenuItem;
    }
}