using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ClowderTask.Controller
{
    class Task
    {
        public void ProcessList()
        { 
        Process[] processList = Process.GetProcesses();

            foreach (Process process in processList)
            {
                Console.WriteLine(process.ProcessName);
            }
        }
    }
}
