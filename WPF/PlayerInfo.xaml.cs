using DataLayer;
using System.Threading;
using System.Windows;

namespace WPF
{
	 /// <summary>
	 /// Interaction logic for PlayerInfo.xaml
	 /// </summary>
	 public partial class PlayerInfo : Window
	 {
		  public PlayerInfo(PlayerInfoVM model)
		  {
				SetCulture(Repo.LoadLangSetting());
				InitializeComponent();
				DataContext = model;
		  }

		  private void SetCulture(string culture)
		  {
				Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
				Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);
		  }

	 }
}


