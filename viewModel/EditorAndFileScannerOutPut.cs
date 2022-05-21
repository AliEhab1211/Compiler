using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Compiler2.Models;
namespace Compiler2.viewModel
{
    public class EditorAndFileScannerOutPut
    {
        public List<Token> EditorScannerOutPut { get; set; }
        public List<Token> FileScannerOutPut { get; set; }
        public int EditorNumberOfErors { get; set; }
        public int FileNumberOfErors { get; set; }
    }
}
