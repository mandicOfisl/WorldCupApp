using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class PlayerRankTableModel
    {
		  public Image Image { get; set; }
		  public string Name { get; set; }
        public int Appearances { get; set; }
        public int NoGoals { get; set; }
        public int NoYC { get; set; }

        public override bool Equals(object obj)
        {
            return obj is PlayerRankTableModel model &&
                   Name == model.Name;
        }
        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }
    }
}
