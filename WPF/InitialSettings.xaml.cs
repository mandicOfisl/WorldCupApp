using DataLayer;
using System.Text;
using System.Windows;

namespace WPF
{
    public partial class InitialSettings : Window
    {
        public InitialSettings()
        {
            InitializeComponent();
				this.DataContext = new InitSettingsVM();
        }

		  private void BtnSave_Click(object sender, RoutedEventArgs e)
		  {
            StringBuilder sb = new StringBuilder();
            InitSettingsVM set = DataContext as InitSettingsVM;
				if (set.Hrv) sb.Append("HRV;");
					 else sb.Append("ENG;");
				
				if (set.MaleCompetition) sb.Append("M;");
					 else sb.Append("F;");

				if (set.SmallScreen) sb.Append("S");
					 else if (set.Fullscreen) sb.Append("L");
						  else sb.Append("M");

				Repo.SaveSettingsToFile(sb.ToString(), "init.txt");
				FavouriteTeam ft = new FavouriteTeam();
				ft.Show();
				this.Hide();
		  }
	 }
}
