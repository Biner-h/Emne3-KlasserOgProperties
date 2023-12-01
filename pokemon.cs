using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emne3_KlasserOgProperties
{
    internal class pokemon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }

        public pokemon(string name, int health, int level)
        {
            Name = name;
            Health = health;
            Level = level;
        }

        public void showInfo()
        {
           console.WriteLine($)
        }
    }
}
