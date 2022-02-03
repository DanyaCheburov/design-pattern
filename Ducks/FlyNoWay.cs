﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class FlyNoWay : IFlyBehavior
    {
        public string fly()
        {
            return "..." + this.GetType();
        }
    }
}
