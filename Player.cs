using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NardiSharp
{
    class Player
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        public Player(string n)
        {
            Name = n;
        }
    }
}
