using DataLayer;
using DataLayer.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WPF
{
	 public partial class PitchUC : UserControl
	 {
		  public List<Player> Players { get; set; }
		  public PitchUC(List<Player> players)
		  {
				InitializeComponent();
				this.DataContext = players;

				DrawColumns(players);
		  }

		  private void DrawColumns(List<Player> players)
		  {
				string formation = Repo.GetFormation(players);
				string[] form = formation.Split('-');
				int colNumber = GetMaxFromFormation(form);
				for (int i = 0; i < colNumber; i++)
				{
					 GridLength colWidth = new GridLength(1, GridUnitType.Star);
					 ColumnDefinition colDef = new ColumnDefinition { Width = colWidth };
					 grid.ColumnDefinitions.Add(colDef);
				}

				PlacePlayers(players, colNumber, form);
		  }

		  private void PlacePlayers(List<Player> players, int colNum, string[] form)
		  {
				int at = 0, mf = 0, df = 0;

				foreach (var player in players)
				{
					 PlayerUcVM playerUcModel = new PlayerUcVM
					 {
						  Name = player.Name,
						  Number = player.ShirtNumber.ToString(),
						  PicturePath = "/Resources/no-image.png"
					 };
					 PlayerUC playerUC = new PlayerUC(playerUcModel);
					 switch (player.Position)
					 {
						  case Position.Goalie:
								Grid.SetRow(playerUC, 3);
								Grid.SetColumn(playerUC, 0);
								Grid.SetColumnSpan(playerUC, colNum);
								grid.Children.Add(playerUC);
								continue;
						  case Position.Defender:
								Grid.SetRow(playerUC, 2);
								CalculateColumnPosition(playerUC, df++, int.Parse(form[1]), colNum);
								grid.Children.Add(playerUC);
								continue;
						  case Position.Midfield:
								Grid.SetRow(playerUC, 1);
								Grid.SetColumn(playerUC, mf++);
								grid.Children.Add(playerUC);
								continue;
						  case Position.Forward:
								Grid.SetRow(playerUC, 0);
								Grid.SetColumn(playerUC, at++);
								grid.Children.Add(playerUC);
								continue;
						  default:
								break;
					 }
				}
		  }

		  private void CalculateColumnPosition(PlayerUC playerUC, int current, int numberInRow, int colNum)
		  {
				switch (colNum - numberInRow)
				{
					 case 0:
						  Grid.SetColumn(playerUC, current); 
						  return;
					 case 1:
						  Grid.SetColumnSpan(playerUC, 2);
						  Grid.SetColumn(playerUC, current);
						  return;
					 case 2:
						  Grid.SetColumnSpan(playerUC, 3);
						  Grid.SetColumn(playerUC, current);
						  return;
					 case 3:
						  Grid.SetColumnSpan(playerUC, 3);
						  Grid.SetColumn(playerUC, current);
						  return;
					 case 4:
						  switch (numberInRow)
						  {
								case 1:
									 Grid.SetColumn(playerUC, 2);
									 break;
								default:
									 Grid.SetColumn(playerUC, current == 0 ? 1 : 3);
									 Grid.SetColumnSpan(playerUC, 2);
									 break;
						  }
						  return;
					 default:
						  Grid.SetColumn(playerUC, current);
						  return;
				}
		  }



		  private int GetMaxFromFormation(string[] form)
		  {
				List<int> l = new List<int>();
				foreach (var num in form)
				{
					 l.Add(int.Parse(num));
				}
				return l.Max();
		  }
	 }
}
