using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.Interface_EX01
{
    internal class MyType : IMyType
    {
        public double salary { get; set; }

        public void MyFun()
        {
            Console.WriteLine("Hello World"); ;
        }
    }
}
