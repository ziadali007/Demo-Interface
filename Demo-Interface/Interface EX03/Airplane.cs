using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.Interface_EX03
{
    internal class Airplane : Iflyable, Imovable
    {
        int Iflyable.speed { get; set; }
        int Imovable.speed { get; set; }
        void Imovable.forward()
        {
            Console.WriteLine("Airplane is moving forward");
        }
        void Imovable.backward()
        {
            Console.WriteLine("Airplane is moving backward");
        }
        void Imovable.left()
        {
            Console.WriteLine("Airplane is moving left");
        }
        void Imovable.right()
        {
            Console.WriteLine("Airplane is moving right");
        }

        void Iflyable.forward()
        {
            Console.WriteLine("Airplane is moving forward");
        }

        void Iflyable.backward()
        {
            Console.WriteLine("Airplane is moving backward");
        }

        void Iflyable.left()
        {
            Console.WriteLine("Airplane is moving left");
        }

        void Iflyable.right()
        {
            Console.WriteLine("Airplane is moving right");
        }
    }
 
}

