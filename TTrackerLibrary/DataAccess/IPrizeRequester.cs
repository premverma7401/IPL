﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTrackerLibrary.DataAccess
{
   public interface IPrizeRequester
    {
        void PrizeComplete(PrizeModel model);
    }
}
