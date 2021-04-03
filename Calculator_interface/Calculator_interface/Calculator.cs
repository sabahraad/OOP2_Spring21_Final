using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_interface
{
    class Calculator: Interface_cal
    {
        public Calculator()
        {

        }

        public double Division(int x, int y)
        {
            double div = (double)x / y;
            Console.WriteLine("Division of {0} and {1} is :{2}", x, y, div);
            return div;
        }

        public int Multiplication(int x, int y)
        {
            int mul = x * y;
            Console.WriteLine("Multiplication of {0} and {1} is :{2}", x, y, mul);
            return mul;
        }

        public int Sub(int x, int y)
        {
            int sub = x - y;
            Console.WriteLine("Subtraction of {0} and {1} is :{2}", x, y, sub);
            return sub;
        }

        public int Sum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("Addition of {0} and {1} is :{2}", x, y, sum);
            return sum;
        }
    }
}
