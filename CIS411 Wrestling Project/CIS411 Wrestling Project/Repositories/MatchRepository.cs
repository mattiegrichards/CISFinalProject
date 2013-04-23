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
        private MatchDBEntities _context = null;

        public MatchRepository()
        {
            _context = new MatchDBEntities();
        }

        public Match[] getAll()
        {
            return _context.Matches.ToArray();
        }

        public void add(Match match2add)
        {
            _context.Matches.Add(match2add);
            _context.SaveChanges();
        }

        public void update(Match match2update)
        {
            _context.Entry(match2update).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void remove(Match match2remove)
        {
            _context.Matches.Remove(match2remove);
            _context.SaveChanges();
        }

        public IQueryable<Match> query(System.Linq.Expressions.Expression<Func<Match, bool>> filter)
        {
            return _context.Matches.Where(filter);
        }
    }
}