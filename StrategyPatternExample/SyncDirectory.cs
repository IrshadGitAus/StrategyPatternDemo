using StrategyPatternExample.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    public class SyncDirectory
    {
        private string _srcDir;
        private string _destDir;
        private IDeleteStrategy _deleteStrategy;

        public SyncDirectory(string srcDir, string destDir, IDeleteStrategy deleteStrategy)
        {
            _srcDir = srcDir;
            _destDir = destDir;
            _deleteStrategy = deleteStrategy;
        }

        public void Sync()
        {
            _deleteStrategy.DeleteExtraFiles(_srcDir, _destDir);
        }

    }
}
