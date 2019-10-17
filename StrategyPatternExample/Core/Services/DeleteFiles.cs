﻿using StrategyPatternExample.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample.Core.Services
{
    public class DeleteFiles : IDeleteStrategy
    {
        public void DeleteExtraFiles(string srcDir, string destDir)
        {
            Console.WriteLine("Delete the files");
        }
    }
}
