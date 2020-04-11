using System.Collections.Generic;

namespace TrackerLibrary
{
    public class MatchUpModel
    {
        public List<MatchUpEntryModel> Entries { get; set; } = new List<MatchUpEntryModel>();
        public List<TeamModel> Winner { get; set; } = new List<TeamModel>();
        public int MatchUpRound { get; set; }

    }
}
