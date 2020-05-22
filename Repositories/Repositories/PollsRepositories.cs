using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class PollsRepositories
    {
        private AyudaSocialDbContext _ayudaSocialDbContext;

        public PollsRepositories()
        {
            _ayudaSocialDbContext = new AyudaSocialDbContext();
        }

        public List<VolunteerPoll> GetVolunteerPolls()
        {
            return _ayudaSocialDbContext.VolunteerPoll.ToList();
        }

        public VolunteerPoll AddVolunteerPoll(VolunteerPoll poll) 
        {
            _ayudaSocialDbContext.VolunteerPoll.Add(poll);
            _ayudaSocialDbContext.SaveChanges();
            return poll;
        }

        public List<HelpPoll> GetHelpPolls()
        {
            return _ayudaSocialDbContext.HelpPoll.ToList();
        }

        public HelpPoll AddHelpPoll(HelpPoll poll)
        {
            _ayudaSocialDbContext.HelpPoll.Add(poll);
            _ayudaSocialDbContext.SaveChanges();
            return poll;
        }
    }
}
