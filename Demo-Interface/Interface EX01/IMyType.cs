using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.Interface_EX01
{
    internal interface IMyType
    {
        void MyFun();

        public double salary { get; set; }


        void print()
        {
            Console.WriteLine("Hello, World!");
        }

        
    }
}
