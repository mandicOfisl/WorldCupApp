using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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


