using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Models
{
    public class AyudaSocialDbContext: DbContext
    {
        public DbSet<HelpPoll> HelpPoll { get; set; }
        public DbSet<VolunteerPoll> VolunteerPoll { get; set; }
        public DbSet<Route> Route { get; set; }
    }
}
