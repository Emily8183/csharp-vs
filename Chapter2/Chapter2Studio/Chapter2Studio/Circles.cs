﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2Studio
{
     public class Circles
    {
        public static double CalculateRadius(float radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
    }
}
