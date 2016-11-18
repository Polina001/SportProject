using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport.Data
{
    class Team
    {
        public int TeamID { get; set; }
        public string Name { get; set; }
        public List<Player> PlayerList { get; set; } 
    }
}
