using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_interface
{
    class Scientific: Calculator,Interface_Sci
    {
        public Scientific()
        {

        }

        public int Absolute(int x)
        {
            int a = Math.Abs(x);
            Console.WriteLine("The Absolute value of {0} is {1}", x, a);
            return a;
        }

        public double Sin_value(double angle)
        {
            double s = Math.Sin(angle);
            Console.WriteLine("Sine value of angle  {0} is {1}", angle, s);
            return s;
        }

        public double X_to_power_y(double x, double y)
        {
            double pow = Math.Pow(x, y);
            Console.WriteLine("The result of {0}^{1} is {2}", x, y, pow);
            return pow;
        }
    }
}
