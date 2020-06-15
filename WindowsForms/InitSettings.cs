using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class InitialSettings : Form
    {
        private static readonly string initSettingsPath = "initSettings.txt";
        public InitialSettings()
        {
            InitializeComponent();
        }

        private void btnSaveInitSettings_Click(object sender, EventArgs e)
        {
            var settings = new StringBuilder();

            settings.Append(rbHrv.Checked ? "HRV;" : "ENG;");
            settings.Append(rbMale.Checked ? "M" : "F");
  
            Repo.SaveSettingsToFile(settings.ToString(), initSettingsPath);

            
            FavouriteTeam favouriteTeam = new FavouriteTeam(settings.ToString());
            favouriteTeam.Show();
            this.Hide();
        }
    }
}
