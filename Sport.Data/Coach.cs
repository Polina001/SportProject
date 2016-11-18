using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport.Data
{
    class Coach
    {
        public int CoachID { get; set; }
        public string Name { get; set; }
        public List<Team> TeamList { get; set; }
    }
}
