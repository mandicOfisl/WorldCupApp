using DataLayer.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataFlow
    {
		  public static JsonSerializerSettings JsonSettings { get; set; } = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            MissingMemberHandling = MissingMemberHandling.Ignore
        };

        public static Task<List<Team>> GetTeams(string url)
        {
            return Task.Run(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                var restClient = new RestClient(url);
                var res = restClient.Execute<List<Team>>(new RestRequest());
                return JsonConvert.DeserializeObject<List<Team>>(res.Content, JsonSettings);
            });
        }

		  public static Task<List<Match>> GetMatches(string url)
        {
            try
            {
                return Task.Run(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    var restClient = new RestClient(url);
                    var res = restClient.Execute<List<Match>>(new RestRequest());
                    return JsonConvert.DeserializeObject<List<Match>>(res.Content, JsonSettings);
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Player> GetPlayersFromMatch(Match match, string fifaCode)
        {
            List<Player> players = new List<Player>();
            if (match.HomeTeam.Code == fifaCode)
            {
                foreach (var player in match.HomeTeamStatistics.StartingEleven)
                {
                    players.Add(player);
                }
                foreach (var player in match.HomeTeamStatistics.Substitutes)
                {
                    players.Add(player);
                }
            }
            else
            {
                foreach (var player in match.AwayTeamStatistics.StartingEleven)
                {
                    players.Add(player);
                }
                foreach (var player in match.AwayTeamStatistics.Substitutes)
                {
                    players.Add(player);
                }
            }
            return players;
        }
    }
}
