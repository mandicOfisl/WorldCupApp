using DataLayer.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataFlow
    {
        public static Task<List<Team>> GetTeams(string url)
        {
            return Task.Run(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                var restClient = new RestClient(url);
                var res = restClient.Execute<List<Team>>(new RestRequest());
                return JsonConvert.DeserializeObject<List<Team>>(res.Content);
            });
        }

        public static Task<List<Match>> GetPlayers(string url)
        {
            return Task.Run(() => 
            {
                Thread.CurrentThread.IsBackground = true;
                var restClient = new RestClient(url);
                var res = restClient.Execute<List<Match>>(new RestRequest());
                return JsonConvert.DeserializeObject<List<Match>>(res.Content);
            });
        }
    }
}
