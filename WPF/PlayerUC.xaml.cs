using System.Windows.Controls;

namespace WPF
{
	 public partial class PlayerUC : UserControl
	 {
		  public string PlayerName { get; set; }
		  public string Number { get; set; }

		  public PlayerUC(PlayerUcVM model)
		  {
				InitializeComponent();
				this.DataContext = model;
				PlayerName = model.Name;
				Number = model.Number;
		  }

	 }
}
