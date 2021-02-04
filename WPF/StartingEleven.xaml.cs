using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WPF
{
	 public partial class StartingEleven : Window
	 {
		  public StartingEleven(StartingElevenVM model)
		  {
				InitializeComponent();
				this.DataContext = model;

				CreateFields(model.HomeStartEleven, model.AwayStartEleven);
		  }

		  private void CreateFields(List<Player> homeTeam, List<Player> awayTeam)
		  {
				PitchUC homePitch = new PitchUC(homeTeam);
				PitchUC awayPitch = new PitchUC(awayTeam);

				Grid.SetRow(homePitch, 1);
				Grid.SetColumn(homePitch, 0);

				Grid.SetRow(awayPitch, 1);
				Grid.SetColumn(awayPitch, 2);

				grid.Children.Add(homePitch);
				grid.Children.Add(awayPitch);
		  }

		  private void Window_Closed(object sender, EventArgs e) => Application.Current.Shutdown();
	 }
}
