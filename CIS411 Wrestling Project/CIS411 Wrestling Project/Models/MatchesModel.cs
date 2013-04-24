using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CIS411_Wrestling_Project.Models
{
    public class MatchesModel
    {
        public decimal matchID { get; set; }
        public string homePlayer { get; set; }
        public string awayPlayer { get; set; }
        public int matchTime { get; set; }
        public int homeBloodTime { get; set; }
        public int awayBloodTime { get; set; }

        public int homePoints { get; set; }
        public int awayPoints { get; set; }
    }

    public class MatchDBContext : DbContext
    {
        public DbSet<MatchesModel> Matches2 { get; set; }

        public DbSet<MatchesModel> MatchModels { get; set; }
    }
}