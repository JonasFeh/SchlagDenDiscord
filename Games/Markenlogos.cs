using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games
{
    public class MarkenlogoEntry
    {
        public MarkenlogoEntry(string theName, string theImagePath)
        {
            Name = theName;
            LogoPath = theImagePath;
        }

        public string LogoPath { get; set; }
        public string Name { get; set; }
    }

    public class Markenlogos
    {
        
    }
}
