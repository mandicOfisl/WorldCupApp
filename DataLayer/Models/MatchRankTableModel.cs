using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class MatchRankTableModel
    {
        public string Venue { get; set; }
        public string Location { get; set; }
        public int Visitors { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }

        public override bool Equals(object obj)
        {
            return obj is MatchRankTableModel model &&
                   Venue == model.Venue &&
                   Location == model.Location &&
                   HomeTeam == model.HomeTeam &&
                   AwayTeam == model.AwayTeam;
        }
        public override int GetHashCode()
        {
            int hashCode = -1611185865;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Venue);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Location);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(HomeTeam);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AwayTeam);
            return hashCode;
        }
    }
}
