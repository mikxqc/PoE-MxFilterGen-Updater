using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoE_MxFilterGen_Updater
{
    class Program
    {
        static void Main(string[] args)
        {
            Web.DownloadFile(@"https://raw.githubusercontent.com/mikxqc/PoE-MxFilter-Data/master/bin/mxfiltergen.exe", "mxfiltergen.exe");
            Process.Start("mxfiltergen.exe");
        }
    }
}
