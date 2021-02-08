using DataLayer;
using System.Threading;
using System.Windows;

namespace WPF
{
	 public partial class TeamInfo : Window
	 {
		  public TeamInfo(TeamInfoVM model)
		  {
				SetCulture(Repo.LoadLangSetting());				
				InitializeComponent();
				this.DataContext = model;
		  }

		  private void SetCulture(string culture)
		  {
				Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
				Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);
		  }
	 }
}
