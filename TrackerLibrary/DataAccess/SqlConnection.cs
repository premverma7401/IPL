using System;

namespace TrackerLibrary
{
    public class SqlConnection : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // TODO - Create method to save new prize in db.
            model.Id = 1;
            return model;
        }
    }
}