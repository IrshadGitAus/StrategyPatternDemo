using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample.Core.Interfaces
{
    public interface IDeleteStrategy
    {
         void DeleteExtraFiles(string srcDir, string destDir);
    }
}
