using DataLayer;
using System.Threading;
using System.Windows;

namespace WPF
{
	 /// <summary>
	 /// Interaction logic for LoadingWindow.xaml
	 /// </summary>
	 public partial class LoadingWindow : Window
	 {
		  public LoadingWindow()
		  {
				SetCulture(Repo.LoadLangSetting());
				InitializeComponent();
		  }

		  private void SetCulture(string culture)
		  {
				Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
				Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);
		  }
	 }
}
