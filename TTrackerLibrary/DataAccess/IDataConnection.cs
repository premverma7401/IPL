using System;
using System.Collections.Generic;
using System.Text;

namespace TTrackerLibrary
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
        PersonModel CreatePerson(PersonModel model);
        List<PersonModel> GetPerson_All();
    }
}
