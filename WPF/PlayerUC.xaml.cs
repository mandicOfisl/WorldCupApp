using System.Windows.Controls;

namespace WPF
{
	 public partial class PlayerUC : UserControl
	 {
		  public PlayerUC(PlayerUcVM model)
		  {
				InitializeComponent();
				this.DataContext = model;
		  }
	 }
}
