﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTrackerLibrary.DataAccess
{
   public interface ITeamRequester
    {
        void TeamComplete(TeamModel model);
    }
}
