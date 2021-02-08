using DataLayer;
using System.Windows.Forms;

namespace WindowsForms
{
	 public partial class LoadingWindow : Form
	 {
		  public LoadingWindow()
		  {
				SetCulture(Repo.LoadLangSetting());
				InitializeComponent();
		  }

		  private void SetCulture(string culture)
		  {
				System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
				System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);
		  }
	 }
}
