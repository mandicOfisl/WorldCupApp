using DataLayer;
using DataLayer.Models;
using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Rankings : Form
    {
        private readonly char maleFemale = Repo.LoadCompetitionSetting();
        private readonly string fifaCode = Repo.LoadFavTeamSetting();

        public List<Match> Matches { get; set; }
        public List<PlayerRankTableModel> PlayerRanks { get; set; }
        public List<MatchRankTableModel> MatchesRanks { get; set; }

		  public Rankings()
        {
            string culture = Repo.LoadLangSetting();
            SetCulture(culture);
            InitializeComponent();
            GetAllMatches();
        }

        private void SetCulture(string culture)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);
        }

        private async void GetAllMatches()
        {
            StringBuilder url = new StringBuilder();
            url.Append(Repo.GetMatchesUrl(maleFemale));
            url.Append(fifaCode);

            LoadingWindow lw = new LoadingWindow();
            lw.Show();

            Matches = await DataFlow.GetMatches(url.ToString());
            PlayerRanks = Ranking.FilterPlayerData(Matches, fifaCode);
            MatchesRanks = Ranking.FilterMatchData(Matches);

            FillDGVTables();
            lw.Close();
        }

        private void FillDGVTables()
        {
            dgvPlayers.RowTemplate.Height = 50;
            dgvPlayers.DataSource = ConvertToDataTable<PlayerRankTableModel>(PlayerRanks);
            dgvMatches.DataSource = ConvertToDataTable<MatchRankTableModel>(MatchesRanks);
        }

        private DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }

            return table;
        }


        private void BtnPrintPlayers_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.PrintDataGridView(dgvPlayers);
        }
        private void BtnPrintMatches_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.PrintDataGridView(dgvMatches);
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

		  private void SelectFavouritePlayersToolStripMenuItem_Click(object sender, EventArgs e)
		  {
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(Properties.Resources.changeSettings, Properties.Resources.warning, btns);
            if (result == DialogResult.Yes)
            {
                string[] p = { "", "", "" };
                Repo.SaveFavouritePlayers(p);
                FavouritePlayers fp = new FavouritePlayers(Repo.LoadFavTeamSetting(), Repo.LoadCompetitionSetting());
                fp.Show();
                this.Hide();
            }
        }

		  private void Rankings_FormClosing(object sender, FormClosingEventArgs e)
		  {
            if (MessageBox.Show(Properties.Resources.exitApp, Properties.Resources.warning, MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
                e.Cancel = true;
        }
	 }
}
