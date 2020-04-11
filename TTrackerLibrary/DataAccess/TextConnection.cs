using System.Collections.Generic;
using System.Linq;
using TTrackerLibrary.DataAccess.TextConnection;

namespace TTrackerLibrary.DataAccess.TextHelpers
{
    public class TextConnection : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string MembersFile = "PersonModels.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> members = MembersFile.FullFilePath().LoadFile().ConvertToPersonModel();

            //int currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            int currentId = 1;
            if (members.Count > 0)
            {
                currentId = members.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            members.Add(model);

            members.SaveToPersonFile(MembersFile);

            return model;
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();

            //int currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }

        public List<PersonModel> GetPerson_All()
        {
            return MembersFile.FullFilePath().LoadFile().ConvertToPersonModel();

        }
    }
}