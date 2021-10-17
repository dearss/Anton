using System;
using System.Collections.Generic;
using System.Text;

namespace Prokopenko
{
    class Solve_x2 : solve_x1, EquatuonEnterface
    {
        protected float disc(float a, float b, float c)
        {
            return b * b - (4 * a * c);
        }

        public List<float> Solve(float a, float b, float c)
        {

            if (a == 0)
            {
                return Solve_x1(b, c);
            }

            float D = disc(a, b, c);

            if (D < 0)
            {
                return null;
            }

            if (D == 0)
                return X = new List<float>() { (-b) / (2 * a) };

            D = (float)Math.Sqrt(D);

            return X = new List<float>() {
                (-b + D) / (2 * a),
                (-b - D) / (2 * a)
            };

        }
    }
}
