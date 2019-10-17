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

            string src="";
            string dest="";

            //NoDelete d = new NoDelete();
            //DeleteFiles d = new DeleteFiles();
            DeleteFilesExceptPDF d = new DeleteFilesExceptPDF();

            SyncDirectory sd = new SyncDirectory(src, dest, d);
            sd.Sync();

            Console.WriteLine("End the sync");

            Console.ReadLine();
        }
    }
}
