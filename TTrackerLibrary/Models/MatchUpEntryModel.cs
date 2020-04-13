using System.Collections.Generic;

namespace TTrackerLibrary
{
    public class MatchUpEntryModel
    {
        public int Id { get; set; }
        public TeamModel TeamCompeting { get; set; } 
        public MatchUpModel ParentMatch { get; set; }
        public double Score { get; set; }
    }
}
