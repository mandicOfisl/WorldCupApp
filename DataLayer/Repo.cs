using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Repo
    {
        public static void SaveSettingsToFile(string settings, string path)
        {
            using (StreamWriter w = new StreamWriter(path))
            {
                w.WriteLine(settings);
            }
        }

    }
}
