using System;
using System.Collections.Generic;
using System.Text;

namespace LB1
{
    class A
    {
        protected double[] x;

        public double[] Function(double a, double b)
        {
            if (a == 0)
            {
                throw new Exception("Нет корней");
            }

            return x = new double[] { (-b / a) };
        }
    }
}
