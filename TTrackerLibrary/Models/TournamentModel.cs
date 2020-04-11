using System.Collections.Generic;

namespace TTrackerLibrary
{
    public class TournamentModel
    {
        public int Id { get; set; }
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        public List<List<MatchUpModel>> Rounds { get; set; } = new List<List<MatchUpModel>>();

        public TournamentModel()
        {


        }

        public TournamentModel(string entreeFee)
        {
            decimal EntryFeeValue = 0;
            decimal.TryParse(entreeFee, out EntryFeeValue);
            EntryFee = EntryFeeValue;
        }
       
    }
}
