using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wrestling.dal;

namespace wrestling.core.Models
{
    public class MatchModel
    {
        public int matchID { get; set; }
        public int homePlayer { get; set; }
        public int awayPlayer { get; set; }
        public TimeSpan? matchTime { get; set; }
        public TimeSpan? homeInjuryTime { get; set; }
        public TimeSpan? awayInjuryTime { get; set; }
        public TimeSpan? homeBloodTime { get; set; }
        public TimeSpan? awayBloodTime { get; set; }
        public int? homePoints { get; set; }
        public int? awayPoints { get; set; }
    }
}
