using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetProcess
{
    internal class GetProperty
    {
        public static string GetPropertyString(string str)
        {
            Process proc = Process.GetProcessesByName(str)[0];
                return string.Format("{0}, {1}, {2}", proc.ProcessName, proc.Id, proc.PriorityClass);
        }
    }
}
