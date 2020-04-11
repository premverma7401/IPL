using System;
using System.Collections.Generic;
using System.Text;

namespace TTrackerLibrary
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
        PersonModel CreatePerson(PersonModel model);
        TeamModel CreateTeam(TeamModel model);
        TournamentModel CreateTournament(TournamentModel model);
        List<PersonModel> GetPerson_All();
        List<TeamModel> GetTeam_All();
      //  List<PrizeModel> GetPrize_All();
    }
}
