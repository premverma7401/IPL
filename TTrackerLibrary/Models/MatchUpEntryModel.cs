using System.Collections.Generic;

namespace TTrackerLibrary
{
    public class MatchUpEntryModel
    {
        public List<TeamModel> TeamCompeting { get; set; } = new List<TeamModel>();
        public List<MatchUpModel> ParentMatch { get; set; } = new List<MatchUpModel>();
        public double Score { get; set; }
    }
}
