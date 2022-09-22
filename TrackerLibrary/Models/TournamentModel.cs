using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        //Name given to this tournament 
        public string TournamentName { get; set; }

        //Amount of money each team needs to put up to enter
        public decimal EntryFee { get; set; }

        //Set of teams that have been entered
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        //List of prizes for the various placings
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        //Matchups per round
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
