using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingSingleResponsibility
{
    class Logger
    {
        public void LoggerEx(Exception ex)
        {
                System.IO.File.WriteAllText(@"C:\Error.txt", ex.ToString());
        }
    }
}
