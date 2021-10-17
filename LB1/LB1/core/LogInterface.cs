using System;
using System.Collections.Generic;
using System.Text;

namespace Prokopenko
{
    interface LogInterface
    {
        LogInterface log(string str);
        LogInterface write();
    }
}
