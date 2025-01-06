using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.Interface_EX03
{
    internal interface Imovable
    {
        public int speed { get; set; }

        void forward();

        public void backward();

        void left();

        public void right();
    }
}
