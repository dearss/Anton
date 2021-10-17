using System;
using System.Collections.Generic;
using System.Text;

namespace LB1
{
    class B : A
    {
        protected double getDiscriminant(double a, double b, double c)
        {
            return b * b - (4 * a * c);
        }

        protected double[] Function(int a, int b, int c)
        {
            if (a == 0)
            {
                return Function(b, c);
            }

            double disc = getDiscriminant(a, b, c);

            if (disc == 0)
            {
                return x = new double[] { -b / (2 * a) };
            }

            if (disc > 0)
            {
                disc = Math.Sqrt(disc);
                return x = new double[] {
                    (-b + disc) / (2 * a),
                    (-b - disc) / (2 * a)
                };
            }

            throw new Exception("Корней нет.");

        }

    }
}
