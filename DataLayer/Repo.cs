using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace DataLayer
{
    public class Repo
    {
		  private const string SETTINGS_FILENAME = @"temp\settings.txt";
		  private const string FOLDER_NAME = "temp";

		  private const string DEF_LANG = "hr";
		  private const char DEF_COMP = 'M';

		  private const string MALE_TEAMS_URL = "http://world-cup-json-2018.herokuapp.com/teams";
		  private const string FEMALE_TEAMS_URL = "http://worldcup.sfg.io/teams";		  
		  private const string MALE_MATCHES_URL = "http://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";
		  private const string FEMALE_MATCHES_URL = "http://worldcup.sfg.io/matches/country?fifa_code=";
		  
		  public static bool CheckForSettingsFile()
		  {
				Directory.CreateDirectory(FOLDER_NAME);

				if (!File.Exists(SETTINGS_FILENAME))
				{
					 return false;
				}

				return true;
		  }

		  public static void CreateSettingsFile()
		  {
				using (StreamWriter w = File.AppendText(SETTINGS_FILENAME))
				{
					 w.WriteLine("## WorldCup App setitngs ##\n");
				}
		  }

		  public static string GetTeamsUrl(char maleFemale) => maleFemale == 'M' ? MALE_TEAMS_URL : FEMALE_TEAMS_URL;

		  public static string GetMatchesUrl(char maleFemale) => maleFemale == 'M' ? MALE_MATCHES_URL : FEMALE_MATCHES_URL;

        public static void SaveSettingsToFile(string settings)
        {
            using (StreamWriter w = File.AppendText(SETTINGS_FILENAME))
            {
                w.WriteLine(settings);
            }
        }
        public static char LoadCompetitionSetting()
        {
            using (StreamReader r = new StreamReader(SETTINGS_FILENAME))
            {
					 string line = r.ReadLine();
					 if (line.StartsWith("MaleFemale"))
					 {
						  char c = line.Split(':')[1].StartsWith("M") ? 'M' : 'F';
						  return c;
					 }
            }
				return DEF_COMP;
        }

		  public static string GetFormation(List<Player> players)
		  {
				int at = 0, mf = 0, df = 0;
				foreach (var player in players)
				{
					 switch (player.Position)
					 {
						  case Position.Goalie:
								continue;
						  case Position.Defender:
								df++;
								continue;
						  case Position.Midfield:
								mf++;
								continue;
						  case Position.Forward:
								at++;
								continue;
						  default:
								break;
					 }
				}
				return df + "-" + mf + "-" + at;
		  }

		  public static string LoadFavTeamSetting()
        {
            using (StreamReader r = new StreamReader(SETTINGS_FILENAME))
            {
                string line = r.ReadLine();
					 if (line.StartsWith("FavTeam"))
					 {
						  string fifaCode = line.Split(':')[1];
						  return fifaCode;
					 }
            }
				throw new Exception();
        }

        public static string LoadLangSetting()
        {
            using (StreamReader r = new StreamReader(SETTINGS_FILENAME))
            {
					 string line = r.ReadLine();
					 if (line.StartsWith("Lang"))
					 {
						  string lang = line.Split(':')[1];
						  return lang.StartsWith("H") ? "hr" : "en";
					 }
            }
				return DEF_LANG;
        }

		  public static string CountTeamMatchStats(string fifaCode, List<Match> matches)
		  {
            int p, w = 0, d = 0, l = 0;

            p = matches.Count;
				foreach (var match in matches)
				{
					 if (match.WinnerCode == fifaCode)
					 {
                    w++;
                    continue;
					 }
					 else if (match.WinnerCode == "Draw")
					 {
                    d++;
                    continue;
					 }
					 else
					 {
                    l++;
                    continue;
					 }
				}
            return p + "/" + w + "/" + d + "/" + l;
        }

		  public static string GetScoreFromMatch(Match match)
		  {
				StringBuilder sb = new StringBuilder();
				sb.Append(match.HomeTeam.Goals);
				sb.Append(" : ");
				sb.Append(match.AwayTeam.Goals);
				return sb.ToString();
		  }

		  public static string CountTeamGoalsStats(string fifaCode, List<Match> matches)
		  {
            long gf = 0, ga = 0, gd;

				foreach (var match in matches)
				{
					 if (match.HomeTeam.Code == fifaCode)
					 {
                    gf += match.HomeTeam.Goals;
                    ga += match.AwayTeam.Goals;
					 }
					 else
					 {
                    gf += match.AwayTeam.Goals;
                    ga += match.HomeTeam.Goals;
					 }
				}
            gd = gf - ga;

            return gf + "/" + ga + "/" + gd;
		  }

		  public static void SaveImage(string file, string name)
		  {
				File.Copy(file,
					 Path.Combine(
						  Path.GetDirectoryName(
								Path.GetDirectoryName(
									 Directory.GetCurrentDirectory())) + @"\img", name + ".png"), true);
		  }
	 }
}
