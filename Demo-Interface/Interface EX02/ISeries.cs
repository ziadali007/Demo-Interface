using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.Interface_EX01
{
    internal interface ISeries
    {
        public int current { get; set; }

        public void Next();

        public void Reset();
    }
}
