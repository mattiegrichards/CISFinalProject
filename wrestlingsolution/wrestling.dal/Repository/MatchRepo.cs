using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wrestling.dal.Repository
{
    public class MatchRepo : IRepository<Match>
    {
        private student10Entities _context = null;

        public MatchRepo() {
        _context = new student10Entities();    
        }

        public Match getById(Match match2get)
        {
            return _context.Matches.Find(match2get.Match_ID);
        }

        public Match[] getAll()
        {
            return _context.Matches.ToArray();
        }

        public void add(Match Match2add)
        {
            _context.Matches.Add(Match2add);
            _context.SaveChanges();
        }

        public void update(Match Match2update)
        {
            _context.Entry(Match2update).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void remove(Match Match2remove)
        {
            _context.Matches.Remove(Match2remove);
            _context.SaveChanges();
        }

        public IQueryable<Match> query(System.Linq.Expressions.Expression<Func<Match, bool>> filter)
        {
            return _context.Matches.Where(filter);
        }
    }
}
