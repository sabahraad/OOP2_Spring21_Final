using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator B = new Calculator();
            B.Sum(20, 55);
            B.Sub(75, 50);
            B.Multiplication(4, 50);
            B.Division(66, 11);

            Scientific S = new Scientific();
            S.Sin_value(124.42);
            S.Absolute(-50);
            S.X_to_power_y(4, 2);
        }
    }
}
