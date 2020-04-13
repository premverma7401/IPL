using System;
using System.Collections.Generic;
using System.Linq;
using TTrackerLibrary;

namespace TrackerUI
{
    public static class TournamentLogic
    {
        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomTeams = RandomTeams(model.EnteredTeams);
            int rounds = FindNumberOfRounds(randomTeams.Count);
            int byes = FindNumberOfByes(rounds, randomTeams.Count);
            model.Rounds.Add(CreateFirstRound(byes, randomTeams));
            CreateOtherRounds(rounds, model);

        }

        private static List<TeamModel> RandomTeams(List<TeamModel> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }
        private static int FindNumberOfRounds(int numberOfTeams)
        {
            int output = 1;
            int val = 2;        //let number of teams 5

            while (val < numberOfTeams) // 2 < 5    //3<5   // 4<5  
            {
                output += 1;  // 1 = 1+1    // 2 = 2+1     // 3= 3+1
                val *= 2;        // 2 = 2*2 // 4 = 4*2     // 8=8*2
            }
            return output;  // 4 rounds
        }
        private static int FindNumberOfByes(int rounds, int numberOfTeams)
        {
            int totalTeams = 0;

            for (int i = 0; i <= rounds; i++) // rounds = 1< 4  2<4 3<4
            {
                totalTeams *= 2;    // 2 // 4 // 6
            }
            int byes = totalTeams - numberOfTeams;
            return byes;
        }
        private static List<MatchUpModel> CreateFirstRound(int byes, List<TeamModel> teams)
        {
            List<MatchUpModel> output = new List<MatchUpModel>();
            MatchUpModel curr = new MatchUpModel();

            foreach (TeamModel team in teams)
            {
                curr.Entries.Add(new MatchUpEntryModel { TeamCompeting = team });

                if (byes > 0 || curr.Entries.Count > 1)
                {
                    curr.MatchUpRound = 1;
                    output.Add(curr);
                    curr = new MatchUpModel();

                    if (byes > 0)
                    {
                        byes -= 1;
                    }
                }
            }

            return output;
        }
        private static void CreateOtherRounds(int rounds, TournamentModel model)
        {
            int round = 2;
            List<MatchUpModel> previousRound = model.Rounds[0];
            List<MatchUpModel> currRound = new List<MatchUpModel>();
            MatchUpModel currMatchUp = new MatchUpModel();

            while (round <= rounds)
            {
                foreach (MatchUpModel match in previousRound)
                {
                    currMatchUp.Entries.Add(new MatchUpEntryModel { ParentMatch = match });
                    if (currMatchUp.Entries.Count>1)
                    {
                        currMatchUp.MatchUpRound = round;
                        currRound.Add(currMatchUp);
                        currMatchUp = new MatchUpModel();   
                    }
                }

                model.Rounds.Add(currRound);
                previousRound = currRound;

                currRound = new List<MatchUpModel>();
                round += 1;
            }
        }

    }
}
