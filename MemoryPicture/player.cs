using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryPicture
{
    
    class player
    {
        string name;
        string username;
        int ponit;

        public player(string n, string un, int p)
        {
            this.name = n;
            this.username = un;
            this.ponit = p;

        }

        int getponit() { return ponit; }
        String getnameplayer() { return name; }

    }
}
