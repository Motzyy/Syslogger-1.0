using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using syslogWrite;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Syslogger write = new Syslogger();
            for (int j = 0; j < 20; j++)
            {
                 write.CreateMessage("TestLog", "Julian", "JulianPC", 1, 14, "das ist eine testnachricht", "225");
                 write.SendMessage("TestDB");
                 Thread.Sleep(20);
            }
        }
    }
}
