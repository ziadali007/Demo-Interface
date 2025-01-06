﻿using Demo_Interface.Interface_EX01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.Interface_EX02
{
    internal class SeriesByThree : ISeries
    {
        public int current { get; set; }

        public void Next()
        {
            current += 3;
        }

        public void Reset()
        {
            current = 0;
        }
    }
}
