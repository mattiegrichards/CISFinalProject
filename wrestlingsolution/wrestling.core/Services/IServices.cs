using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wrestling.core.Models;

namespace wrestling.core.Services
{
    public interface IServices
    {
        ICollection<MatchModel> listMatches();
        ICollection<MatchModel> listMatchesByHomePlayer(decimal homePlayer);
        MatchModel getMatchById(decimal matchID);
    }
}
