using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.Interface_EX03
{
    internal class Car : Imovable
    {
        public int speed { get; set; }

        public void backward()
        {
            Console.WriteLine("Car Move Backward");
        }

        public void forward()
        {
            Console.WriteLine("Car Move Forward");
        }

        public void left()
        {
            Console.WriteLine("Car Move Left");
        }

        public void right()
        {
            Console.WriteLine("Car Move Right");
        }
    }
}
