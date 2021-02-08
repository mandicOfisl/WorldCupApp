using System;

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
				System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavouritePlayers));
				this.cmsFavourite = new System.Windows.Forms.ContextMenuStrip(this.components);
				this.addOption = new System.Windows.Forms.ToolStripMenuItem();
				this.rmvOption = new System.Windows.Forms.ToolStripMenuItem();
				this.loadOption = new System.Windows.Forms.ToolStripMenuItem();
				this.lblFavouritePlayers = new System.Windows.Forms.Label();
				this.lblAllPlayers = new System.Windows.Forms.Label();
				this.flpFavouritePlayers = new System.Windows.Forms.FlowLayoutPanel();
				this.flpAllPlayers = new System.Windows.Forms.FlowLayoutPanel();
				this.btnSaveFavouritePlayers = new System.Windows.Forms.Button();
				this.menuStrip1 = new System.Windows.Forms.MenuStrip();
				this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.changeCompetitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.changeFavouriteTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.changeLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.cmsFavourite.SuspendLayout();
				this.menuStrip1.SuspendLayout();
				this.SuspendLayout();
				// 
				// cmsFavourite
				// 
				this.cmsFavourite.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOption,
            this.rmvOption,
            this.loadOption});
				this.cmsFavourite.Name = "cmsFavourite";
				resources.ApplyResources(this.cmsFavourite, "cmsFavourite");
				// 
				// addOption
				// 
				this.addOption.Name = "addOption";
				resources.ApplyResources(this.addOption, "addOption");
				this.addOption.Click += new System.EventHandler(this.AddOption_Click);
				// 
				// rmvOption
				// 
				this.rmvOption.Name = "rmvOption";
				resources.ApplyResources(this.rmvOption, "rmvOption");
				this.rmvOption.Click += new System.EventHandler(this.RmvOption_Click);
				// 
				// loadOption
				// 
				this.loadOption.Name = "loadOption";
				resources.ApplyResources(this.loadOption, "loadOption");
				this.loadOption.Click += new System.EventHandler(this.LoadOption_Click);
				// 
				// lblFavouritePlayers
				// 
				resources.ApplyResources(this.lblFavouritePlayers, "lblFavouritePlayers");
				this.lblFavouritePlayers.Name = "lblFavouritePlayers";
				// 
				// lblAllPlayers
				// 
				resources.ApplyResources(this.lblAllPlayers, "lblAllPlayers");
				this.lblAllPlayers.Name = "lblAllPlayers";
				// 
				// flpFavouritePlayers
				// 
				this.flpFavouritePlayers.AllowDrop = true;
				this.flpFavouritePlayers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
				resources.ApplyResources(this.flpFavouritePlayers, "flpFavouritePlayers");
				this.flpFavouritePlayers.Name = "flpFavouritePlayers";
				this.flpFavouritePlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.FlpFavouritePlayers_DragDrop);
				this.flpFavouritePlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.FlpFavouritePlayers_DragEnter);
				// 
				// flpAllPlayers
				// 
				this.flpAllPlayers.AllowDrop = true;
				resources.ApplyResources(this.flpAllPlayers, "flpAllPlayers");
				this.flpAllPlayers.Name = "flpAllPlayers";
				this.flpAllPlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.FlpAllPlayers_DragDrop);
				this.flpAllPlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.FlpFavouritePlayers_DragEnter);
				// 
				// btnSaveFavouritePlayers
				// 
				this.btnSaveFavouritePlayers.BackgroundImage = global::WindowsForms.Properties.Resources.Programming_Save_icon;
				resources.ApplyResources(this.btnSaveFavouritePlayers, "btnSaveFavouritePlayers");
				this.btnSaveFavouritePlayers.Name = "btnSaveFavouritePlayers";
				this.btnSaveFavouritePlayers.UseVisualStyleBackColor = true;
				this.btnSaveFavouritePlayers.Click += new System.EventHandler(this.BtnSaveFavouritePlayers_Click);
				// 
				// menuStrip1
				// 
				this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem});
				resources.ApplyResources(this.menuStrip1, "menuStrip1");
				this.menuStrip1.Name = "menuStrip1";
				// 
				// settingToolStripMenuItem
				// 
				this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeCompetitionToolStripMenuItem,
            this.changeFavouriteTeamToolStripMenuItem,
            this.changeLanguageToolStripMenuItem});
				this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
				resources.ApplyResources(this.settingToolStripMenuItem, "settingToolStripMenuItem");
				// 
				// changeCompetitionToolStripMenuItem
				// 
				this.changeCompetitionToolStripMenuItem.Name = "changeCompetitionToolStripMenuItem";
				resources.ApplyResources(this.changeCompetitionToolStripMenuItem, "changeCompetitionToolStripMenuItem");
				this.changeCompetitionToolStripMenuItem.Click += new System.EventHandler(this.ChangeCompetitionOrLanguage);
				// 
				// changeFavouriteTeamToolStripMenuItem
				// 
				this.changeFavouriteTeamToolStripMenuItem.Name = "changeFavouriteTeamToolStripMenuItem";
				resources.ApplyResources(this.changeFavouriteTeamToolStripMenuItem, "changeFavouriteTeamToolStripMenuItem");
				this.changeFavouriteTeamToolStripMenuItem.Click += new System.EventHandler(this.ChangeFavouriteTeamToolStripMenuItem_Click);
				// 
				// changeLanguageToolStripMenuItem
				// 
				this.changeLanguageToolStripMenuItem.Name = "changeLanguageToolStripMenuItem";
				resources.ApplyResources(this.changeLanguageToolStripMenuItem, "changeLanguageToolStripMenuItem");
				this.changeLanguageToolStripMenuItem.Click += new System.EventHandler(this.ChangeCompetitionOrLanguage);
				// 
				// FavouritePlayers
				// 
				resources.ApplyResources(this, "$this");
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.Controls.Add(this.menuStrip1);
				this.Controls.Add(this.flpAllPlayers);
				this.Controls.Add(this.flpFavouritePlayers);
				this.Controls.Add(this.btnSaveFavouritePlayers);
				this.Controls.Add(this.lblAllPlayers);
				this.Controls.Add(this.lblFavouritePlayers);
				this.Name = "FavouritePlayers";
				this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FavouritePlayers_FormClosing);
				this.cmsFavourite.ResumeLayout(false);
				this.menuStrip1.ResumeLayout(false);
				this.menuStrip1.PerformLayout();
				this.ResumeLayout(false);
				this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsFavourite;
        private System.Windows.Forms.ToolStripMenuItem rmvOption;
        private System.Windows.Forms.Label lblFavouritePlayers;
        private System.Windows.Forms.Label lblAllPlayers;
        private System.Windows.Forms.Button btnSaveFavouritePlayers;
        private System.Windows.Forms.FlowLayoutPanel flpFavouritePlayers;
        private System.Windows.Forms.FlowLayoutPanel flpAllPlayers;
        private System.Windows.Forms.ToolStripMenuItem loadOption;
        private System.Windows.Forms.ToolStripMenuItem addOption;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeCompetitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFavouriteTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLanguageToolStripMenuItem;
    }
}