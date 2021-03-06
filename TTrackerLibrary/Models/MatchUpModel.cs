﻿using System.Collections.Generic;

namespace TTrackerLibrary
{
    public class MatchUpModel
    {
        public int Id { get; set; }
        public List<MatchUpEntryModel> Entries { get; set; } = new List<MatchUpEntryModel>();
        public TeamModel Winner { get; set; }
        public int MatchUpRound { get; set; }

    }
}
