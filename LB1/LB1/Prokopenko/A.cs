using System;
using System.Collections.Generic;
using System.Text;

namespace Prokopenko
{
    class solve_x1
    {
        protected List<float> X;
        public List<float> Solve_x1(float a, float b)
        {

            if (a == 0)
                return null;

            return X = new List<float>() { -b / a };

        }
    }
}
