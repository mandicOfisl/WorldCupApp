using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;

namespace DataLayer
{
    public class Repo
    {

		  private const string SETTINGS_FILENAME = "settings.txt";
		  private const string NO_IMG_FILENAME = @"WorldCupApp\temp\img\no-image.png";

		  private const string SETTINGS_FOLDER_NAME = @"WorldCupApp\temp";
		  private const string IMG_FOLDER_NAME = @"WorldCupApp\temp\img";

		  private const string DEF_LANG = "hr";
		  private const char DEF_COMP = 'M';


		  private const string MALE_TEAMS_URL = "http://world-cup-json-2018.herokuapp.com/teams";
		  private const string FEMALE_TEAMS_URL = "http://worldcup.sfg.io/teams";		  
		  private const string MALE_MATCHES_URL = "http://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";
		  private const string FEMALE_MATCHES_URL = "http://worldcup.sfg.io/matches/country?fifa_code=";
		  
		  public static bool CheckForSettingsFile()
		  {
				string progDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

				string settingsFolderPath = Path.Combine(progDataFolder, SETTINGS_FOLDER_NAME);
				Directory.CreateDirectory(settingsFolderPath);

				string filePath = Path.Combine(settingsFolderPath, SETTINGS_FILENAME);

				string imgFolderPath = Path.Combine(progDataFolder, IMG_FOLDER_NAME);
				Directory.CreateDirectory(imgFolderPath);

				if (File.Exists(filePath))
				{
					 return true;
				}
				else
				{
					 CreateSettingsFile();
					 return false;
				}
		  }

		  public static void CreateSettingsFile()
		  {
				string fold = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
				string fn = Path.Combine(fold, SETTINGS_FOLDER_NAME, SETTINGS_FILENAME);

				using (StreamWriter w = File.AppendText(fn))
				{
					 w.WriteLine("## WorldCup App setitngs ##");
					 w.WriteLine("Lang:");
					 w.WriteLine("MaleFemale:");
					 w.WriteLine("FavTeam:");
					 w.WriteLine("P:");
					 w.WriteLine("P:");
					 w.WriteLine("P:");
					 w.WriteLine("Screen:");
				}
		  }

        public static string LoadLangSetting()
        {
				try
				{
					 string fold = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
					 string fn = Path.Combine(fold, SETTINGS_FOLDER_NAME, SETTINGS_FILENAME);

					 string[] lines = File.ReadAllLines(fn);

					 return lines[1].Split(':')[1];
				}
				catch (Exception)
				{
					 return DEF_LANG;
				}
        }

		  public static List<string> LoadFavPlayers()
		  {
				List<string> players = new List<string>();

				string fold = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
				string fn = Path.Combine(fold, SETTINGS_FOLDER_NAME, SETTINGS_FILENAME);

				string[] lines = File.ReadAllLines(fn);

				try
				{
					 for (int i = 0; i < 3; i++)
					 {
						  players.Add(lines[4 + i].Split(':')[1]);
					 }
				} catch (Exception)
				{
				}
					 
				return players;

		  }
		  public static string LoadScreenSizeSetting()
		  {
				string fold = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
				string fn = Path.Combine(fold, SETTINGS_FOLDER_NAME, SETTINGS_FILENAME);

				string[] lines = File.ReadAllLines(fn);

				return lines[7].Split(':')[1];
		  }

		  public static int CountPlayerYc(string plName, Match match)
		  {
				int yc = 0;

				List<TeamEvent> allEvents = new List<TeamEvent>();
				allEvents.AddRange(match.HomeTeamEvents);
				allEvents.AddRange(match.AwayTeamEvents);

				foreach (var evnt in allEvents)
				{
					 if (evnt.TypeOfEvent == "yellow-card" && evnt.Player == plName)
					 {
						  yc++;

					 }
				}
				return yc;
		  }

		  public static int CountPlayerGoals(string plName, Match match)
		  {
				int goals = 0;

				List<TeamEvent> allEvents = new List<TeamEvent>();
				allEvents.AddRange(match.HomeTeamEvents);
				allEvents.AddRange(match.AwayTeamEvents);

				foreach (var evnt in allEvents)
				{
					 if (evnt.TypeOfEvent == "goal" && evnt.Player == plName) goals++;
				}
				return goals;
		  }

		  public static char LoadCompetitionSetting()
        {
				string fold = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
				string fn = Path.Combine(fold, SETTINGS_FOLDER_NAME, SETTINGS_FILENAME);

				string[] lines = File.ReadAllLines(fn);

				return lines[2].Split(':')[1].ToCharArray()[0];

				//using (StreamReader r = new StreamReader(SETTINGS_FILENAME))
    //        {
				//	 string line = r.ReadLine();
				//	 if (line.StartsWith("MaleFemale"))
				//	 {
				//		  char c = line.Split(':')[1].StartsWith("M") ? 'M' : 'F';
				//		  return c;
				//	 }
    //        }
				//return DEF_COMP;
        }

		  public static string LoadFavTeamSetting()
        {
				string fold = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
				string fn = Path.Combine(fold, SETTINGS_FOLDER_NAME, SETTINGS_FILENAME);

				string[] lines = File.ReadAllLines(fn);

				return lines[3].Split(':')[1];
        }
		  
		  public static string CheckForPlayerImage(string name)
		  {
				string progDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
				string imgFolderPath = Path.Combine(progDataFolder, IMG_FOLDER_NAME);

				string img = Path.Combine(imgFolderPath, name + ".png");

				return File.Exists(img) ? img : "";
		  }

        public static void SaveSettingsToFile(string settings, string settingType)
        {
				string fold = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
				string fn = Path.Combine(fold, SETTINGS_FOLDER_NAME, SETTINGS_FILENAME);

				string[] lines = File.ReadAllLines(fn);

				for (int i = 0; i < lines.Length; i++)
				{
					 if (lines[i].StartsWith(settingType))
					 {
						  try
						  {
								string oldValue = lines[i].Split(':')[1];
								lines[i] = lines[i].Replace(oldValue, settings);
						  }
						  catch (Exception)
						  {
								lines[i] = lines[i] + settings;
						  }
					 }
				}

				File.WriteAllLines(fn, lines);
        }

		  public static void SaveFavouritePlayers(string[] players)
		  {
				string fold = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
				string fn = Path.Combine(fold, SETTINGS_FOLDER_NAME, SETTINGS_FILENAME);

				string[] lines = File.ReadAllLines(fn);

				try
				{
					 for (int i = 0; i < 3; i++)
					 {
						  try
						  {
								string oldValue = lines[i].Split(':')[1];
								lines[4 + i] = lines[4 + i].Replace(oldValue, players[i]);
						  }
						  catch (Exception)
						  {
								lines[4 + i] = lines[4 + i] + players[i];
						  }
					 }
				} 
				finally
				{
					 File.WriteAllLines(fn, lines);
				}
		  }
		  
		  public static void SaveImage(string file, string name)
		  {
				string progDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
				string imgFolderPath = Path.Combine(progDataFolder, IMG_FOLDER_NAME);

				File.Copy(file, Path.Combine(imgFolderPath, name + ".png"), true);


				//File.Copy(file, Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + @"\img", name + ".png"), true);
		  }
		  
		  public static string GetTeamsUrl(char maleFemale) => maleFemale == 'm' ? MALE_TEAMS_URL : FEMALE_TEAMS_URL;
		  
		  public static string GetMatchesUrl(char maleFemale) => maleFemale == 'm' ? MALE_MATCHES_URL : FEMALE_MATCHES_URL;
		  
		  internal static Image GetPlayerImage(string playerName)
		  {
				string imageFile = CheckForPlayerImage(playerName);
				if (File.Exists(imageFile))
				{
					 return new Bitmap(Image.FromFile(imageFile), new Size(50, 50));
				}
				return null;
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

	 }
}
