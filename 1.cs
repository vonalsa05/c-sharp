using CS1;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    class Program
    {
        static void Main()
        {
            Complex[] karanoTest = Solver.Kordan(10.0, 9.0, 8.0, 7.0);
            Complex[] vietaTest = Solver.Vieta(1, 2, -3, 5);

            Console.WriteLine(Solver.Kordan(10.0, 9.0, 8.0, 7.0));
            Console.WriteLine(Solver.Vieta(1, 2, -3, 5));
        }
    }
}