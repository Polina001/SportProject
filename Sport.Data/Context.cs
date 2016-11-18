using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport.Data
{
    class Context : DbContext
    {
        public DbSet<Player> PlayerDb { get; set; }
        public DbSet<Team> TeamDb { get; set; }

        public DbSet<Coach> CoachDb { get; set; }

        public Context() : base("localsql")
        {

        }

    }
}
