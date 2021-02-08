namespace WindowsForms
{
    partial class Rankings
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
				System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rankings));
				this.dgvPlayers = new System.Windows.Forms.DataGridView();
				this.dgvMatches = new System.Windows.Forms.DataGridView();
				this.btnPrintPlayers = new System.Windows.Forms.Button();
				this.btnPrintMatches = new System.Windows.Forms.Button();
				this.menuStrip1 = new System.Windows.Forms.MenuStrip();
				this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.changeCompetitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.changeFavouriteTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.changeLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.selectFavouritePlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
				((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
				this.menuStrip1.SuspendLayout();
				this.SuspendLayout();
				// 
				// dgvPlayers
				// 
				this.dgvPlayers.AllowUserToAddRows = false;
				this.dgvPlayers.AllowUserToDeleteRows = false;
				this.dgvPlayers.AllowUserToOrderColumns = true;
				this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
				resources.ApplyResources(this.dgvPlayers, "dgvPlayers");
				this.dgvPlayers.Name = "dgvPlayers";
				this.dgvPlayers.ReadOnly = true;
				// 
				// dgvMatches
				// 
				this.dgvMatches.AllowUserToAddRows = false;
				this.dgvMatches.AllowUserToDeleteRows = false;
				this.dgvMatches.AllowUserToOrderColumns = true;
				this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
				resources.ApplyResources(this.dgvMatches, "dgvMatches");
				this.dgvMatches.Name = "dgvMatches";
				this.dgvMatches.ReadOnly = true;
				// 
				// btnPrintPlayers
				// 
				resources.ApplyResources(this.btnPrintPlayers, "btnPrintPlayers");
				this.btnPrintPlayers.Name = "btnPrintPlayers";
				this.btnPrintPlayers.UseVisualStyleBackColor = true;
				this.btnPrintPlayers.Click += new System.EventHandler(this.BtnPrintPlayers_Click);
				// 
				// btnPrintMatches
				// 
				resources.ApplyResources(this.btnPrintMatches, "btnPrintMatches");
				this.btnPrintMatches.Name = "btnPrintMatches";
				this.btnPrintMatches.UseVisualStyleBackColor = true;
				this.btnPrintMatches.Click += new System.EventHandler(this.BtnPrintMatches_Click);
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
            this.changeLanguageToolStripMenuItem,
            this.selectFavouritePlayersToolStripMenuItem});
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
				// selectFavouritePlayersToolStripMenuItem
				// 
				this.selectFavouritePlayersToolStripMenuItem.Name = "selectFavouritePlayersToolStripMenuItem";
				resources.ApplyResources(this.selectFavouritePlayersToolStripMenuItem, "selectFavouritePlayersToolStripMenuItem");
				this.selectFavouritePlayersToolStripMenuItem.Click += new System.EventHandler(this.SelectFavouritePlayersToolStripMenuItem_Click);
				// 
				// Rankings
				// 
				resources.ApplyResources(this, "$this");
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.Controls.Add(this.btnPrintMatches);
				this.Controls.Add(this.btnPrintPlayers);
				this.Controls.Add(this.dgvMatches);
				this.Controls.Add(this.dgvPlayers);
				this.Controls.Add(this.menuStrip1);
				this.MainMenuStrip = this.menuStrip1;
				this.Name = "Rankings";
				this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rankings_FormClosing);
				this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Rankings_FormClosed);
				((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
				((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
				this.menuStrip1.ResumeLayout(false);
				this.menuStrip1.PerformLayout();
				this.ResumeLayout(false);
				this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.Button btnPrintPlayers;
        private System.Windows.Forms.Button btnPrintMatches;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeCompetitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFavouriteTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLanguageToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem selectFavouritePlayersToolStripMenuItem;
	 }
}