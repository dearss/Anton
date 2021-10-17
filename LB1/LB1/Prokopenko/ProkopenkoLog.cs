using System;
using System.Collections.Generic;
using System.Text;

namespace LB1
{
    class ProkopenkoLog : LogAbstract, LogInterface
    {
        private static ProkopenkoLog instance;
        List<string> ListArr = new List<string>();
        public static ProkopenkoLog I()
        {
            if (instance == null)
                instance = new ProkopenkoLog();
            return instance;
        }

        public LogInterface log(string str)
        {
            ListArr.Add(str);
            return this;
        }

        public LogInterface write()
        {
            writeConsole(ListArr.ToArray());
            return this;
        }
    }
}
