using System.Windows;

namespace WPF
{
	 public partial class TeamInfo : Window
	 {
		  public TeamInfo(TeamInfoVM model)
		  {
				InitializeComponent();
				this.DataContext = model;
		  }
	 }
}
