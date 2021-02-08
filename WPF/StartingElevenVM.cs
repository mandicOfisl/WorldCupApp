using DataLayer.Models;
using System.Collections.Generic;

namespace WPF
{
	 public class StartingElevenVM
	 {
		  public DataLayer.Team HomeTeam { get; set; }
		  public DataLayer.Team AwayTeam { get; set; }
		  public List<Player> HomeStartEleven { get; set; }
		  public List<Player> AwayStartEleven { get; set; }
		  public string Score { get; set; }
		  public Match Match { get; set; }
	 }
}