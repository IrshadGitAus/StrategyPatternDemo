using StrategyPatternExample.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start the sync");

            SyncDirectory sd = new SyncDirectory();
            sd.processFiles();

            Console.WriteLine("End the sync");

            Console.ReadLine();
        }
    }
}
