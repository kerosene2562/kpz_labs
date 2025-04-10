using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Flyweight.FlyWord
{
    static class MemoryMonitor
    {
        public static void CheckCurrentProcess()
        {
            Process proc = Process.GetCurrentProcess();
            Console.WriteLine($"Allocated Private Memory: {proc.PrivateMemorySize64.ToSmallestFullSize()}");
            Console.WriteLine($"Allovated Physical Memory: {proc.WorkingSet64.ToSmallestFullSize()}");
        }
    }
}
