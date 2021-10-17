using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Prokopenko
{
    class ProkopenkoException : Exception
    {
        public ProkopenkoException(string message) : base(message) { }
    }
}
