using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wrestling.core.Models;
using wrestling.dal;
using wrestling.dal.Repository;

namespace wrestling.core.Services
{
    class MatchService : wrestling.core.Services.IServices
    {
        public ICollection<Models.MatchModel> listMatches()
        {
            MatchRepo matchRepo = new MatchRepo();
            IEnumerable<Match> matches = matchRepo.getAll();

            ICollection<MatchModel> matchModels = new List<MatchModel>();
            MatchModel matchModel = null;
            foreach (Match match in matches)
            {
                matchModel = new MatchModel();
                matchModel.matchID = match.Match_ID;
                matchModel.homePlayer = match.Home_Player_ID;
                matchModel.awayPlayer = match.Away_Player_ID;
                matchModel.matchTime = match.Match_Time;
                matchModel.homeBloodTime = match.Home_Blood_Time;
                matchModel.awayBloodTime = match.Away_Blood_Time;
                matchModel.homeInjuryTime = match.Home_Injury_Time;
                matchModel.awayInjuryTime = match.Away_Injury_Time;
                matchModel.homePoints = match.Home_Points;
                matchModel.awayPoints = match.Away_Points;
                
                matchModels.Add(matchModel);
            }
            matchRepo = null;
            return MatchModels;
        }

        public ICollection<Models.MatchModel> listMatchesByHomePlayer(decimal homePlayer)
        {
            throw new NotImplementedException();
        }

        public Models.MatchModel getMatchById(decimal matchID)
        {
            throw new NotImplementedException();
        }
    }
}
