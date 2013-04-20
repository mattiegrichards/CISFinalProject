using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CIS411_Wrestling_Project.Models
{
    public class Match
    {
        public int ID { get; set; }
        public int MatchTime { get; set; }
        public int HomePoints { get; set; }
        public int AwayPoints { get; set; }
    }

    public class MatchDBContext : DbContext
    {
        public DbSet<Match> Matches { get; set; }
    }
}