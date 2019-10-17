using StrategyPatternExample.Core.Interfaces;
using StrategyPatternExample.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    public class SyncDirectory
    {
        string _srcDir;
        string _destDir;
        //NoDelete d;
        DeleteFiles d;
        //DeleteFilesExceptPDF d;

        public SyncDirectory()
        {
            _srcDir = "";
            _destDir = "";

            /* NOw that we are applying Depency Injection, these lines with new should not exist.
              And we need interfaces for each of the classes below
            */
            //d = new NoDelete();
            d = new DeleteFiles();
            //d = new DeleteFilesExceptPDF();                                     
        }

        public void processFiles()
        {
            Sync(_srcDir, _destDir, d);
        }

        public void Sync(string srcDir, string destDir, IDeleteStrategy deleteStrategy)
        {
            deleteStrategy.DeleteExtraFiles(_srcDir, _destDir);
        }

    }
}
