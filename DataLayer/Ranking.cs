using DataLayer.Models;
using System.Collections.Generic;

namespace DataLayer
{
    public class Ranking
    {
        public static List<PlayerRankTableModel> FilterPlayerData(List<Match> matches, string fifaCode)
		  {
				List<PlayerRankTableModel> playersRnkTblMdls = new List<PlayerRankTableModel>();
				HashSet<string> appearedPlayers = GetAllAppearedPlayers(matches, fifaCode);
				foreach (var p in appearedPlayers)
				{
					 playersRnkTblMdls.Add(new PlayerRankTableModel
					 {
						  Name = p,
						  Appearances = 0,
						  NoGoals = 0,
						  NoYC = 0,
                    Image = Repo.GetPlayerImage(p)
					 });
				}

				playersRnkTblMdls = CountAppearances(playersRnkTblMdls, matches, fifaCode);
				playersRnkTblMdls = CountYcAndGoals(matches, fifaCode, playersRnkTblMdls);

				return playersRnkTblMdls;
		  }

		  private static List<PlayerRankTableModel> CountYcAndGoals(List<Match> matches, string fifaCode, List<PlayerRankTableModel> playersRnkTblMdls)
		  {
				foreach (Match m in matches)
				{
					 if (m.HomeTeam.Code == fifaCode)
					 {
						  foreach (var e in m.HomeTeamEvents)
						  {
								switch (e.TypeOfEvent)
								{
									 case "yellow-card":
										  playersRnkTblMdls.Find(p => p.Name == e.Player).NoYC++;
										  break;
									 case "goal":
										  playersRnkTblMdls.Find(p => p.Name == e.Player).NoGoals++;
										  break;
									 default:
										  break;
								}
						  }
					 }
					 else
					 {
						  foreach (var e in m.AwayTeamEvents)
						  {
								switch (e.TypeOfEvent)
								{
									 case "yellow-card":
										  playersRnkTblMdls.Find(p => p.Name == e.Player).NoYC++;
										  break;
									 case "goal":
										  playersRnkTblMdls.Find(p => p.Name == e.Player).NoGoals++;
										  break;
									 default:
										  break;
								}
						  }
					 }
				}
            return playersRnkTblMdls;
		  }


		  private static List<PlayerRankTableModel> CountAppearances(List<PlayerRankTableModel> rtm, List<Match> matches, string fifaCode)
        {
            foreach (Match m in matches)
            {
                if (m.HomeTeam.Code == fifaCode)
                {
                    foreach (var plyr in m.HomeTeamStatistics.StartingEleven)
                    {
                        rtm.Find(p => p.Name == plyr.Name).Appearances++;
                    }
                    foreach (var teamEvent in m.HomeTeamEvents)
                    {
                        if (teamEvent.TypeOfEvent == "substitution-in")
                        {
                            rtm.Find(p => p.Name == teamEvent.Player).Appearances++;
                        }
                    }
                }
                else
                {
                    foreach (var plyr in m.AwayTeamStatistics.StartingEleven)
                    {
                        rtm.Find(p => p.Name == plyr.Name).Appearances++;
                    }
                    foreach (var teamEvent in m.AwayTeamEvents)
                    {
                        if (teamEvent.TypeOfEvent == "substitution-in")
                        {
                            rtm.Find(p => p.Name == teamEvent.Player).Appearances++;
                        }
                    }
                }
            }
            return rtm;
        }
        private static HashSet<string> GetAllAppearedPlayers(List<Match> matches, string fifaCode)
        {
            HashSet<string> plyrs = new HashSet<string>();

            foreach (Match m in matches)
            {
                if (m.HomeTeam.Code == fifaCode)
                {
                    foreach (var player in m.HomeTeamStatistics.StartingEleven)
                    {
                        plyrs.Add(player.Name);
                    }
                    foreach (var teamEvent in m.HomeTeamEvents)
                    {
                        if (teamEvent.TypeOfEvent == "substitution-in")
                        {
                            plyrs.Add(teamEvent.Player);
                        }
                    }
                }
                else
                {
                    foreach (var player in m.AwayTeamStatistics.StartingEleven)
                    {
                        plyrs.Add(player.Name);
                    }
                    foreach (var teamEvent in m.AwayTeamEvents)
                    {
                        if (teamEvent.TypeOfEvent == "substitution-in")
                        {
                            plyrs.Add(teamEvent.Player);
                        }
                    }
                }
            }
            return plyrs;
        }
        public static List<MatchRankTableModel> FilterMatchData(List<Match> matches)
        {
            List<MatchRankTableModel> mrtm = new List<MatchRankTableModel>();

            foreach (Match m in matches)
            {
                mrtm.Add(new MatchRankTableModel
                {
                    Venue = m.Location,
                    Location = m.Venue,
                    Visitors = int.Parse(m.Attendance),
                    HomeTeam = m.HomeTeamCountry,
                    AwayTeam = m.AwayTeamCountry
                });
            }
            return mrtm;
        }
    }
}
