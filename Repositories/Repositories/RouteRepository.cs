using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class RouteRepository
    {
        private AyudaSocialDbContext _ayudaSocialDbContext;

        public RouteRepository()
        {
            _ayudaSocialDbContext = new AyudaSocialDbContext();
        }

        public IList<Route> GetAll()
        {
            return _ayudaSocialDbContext.Route.ToList(); 
        }

        public Route Add(Route route)
        {
            _ayudaSocialDbContext.Route.Add(route);
            _ayudaSocialDbContext.SaveChanges();
            return route;
        }
    }
}
