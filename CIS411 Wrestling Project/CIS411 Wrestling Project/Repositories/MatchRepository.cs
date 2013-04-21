using CIS411_Wrestling_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using CIS411_Wrestling_Project.Models;

namespace CIS411_Wrestling_Project.Repositories
{
    public class MatchRepository : IRepository<Match>
    {
        private MatchDBContext _context = null;

        public MatchRepository()
        {
            _context = new MatchDBContext();
        }

        public Match getById(Match object2get)
        {
            throw new NotImplementedException();
        }

        public Match[] getAll()
        {
            throw new NotImplementedException();
        }

        public void add(Match match2add)
        {
            throw new NotImplementedException();
        }

        public void update(Match match2update)
        {
            throw new NotImplementedException();
        }

        public void remove(Match match2remove)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Match> query(System.Linq.Expressions.Expression<Func<Match, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}