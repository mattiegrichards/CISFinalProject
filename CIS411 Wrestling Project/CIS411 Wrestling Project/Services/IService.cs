using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIS411_Wrestling_Project.Models

namespace CIS411_Wrestling_Project.Services
{
    public interface IService
    {
        ICollection<MatchModel> listMatches();
    }
}