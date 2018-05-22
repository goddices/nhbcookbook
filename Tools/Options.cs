using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine.Attributes;

namespace NHibernateCookbook.Tools
{
    public class Options
    {
        //[RequiredArgument(0, "dir", "Directory")]
        //public string Directory { get; set; }

        //[OptionalArgument("*.*", "pattern", "Search pattern")]
        //public string SearchPattern { get; set; }

        [RequiredArgument(0, "sn", "name of a sub program to run")]
        public string SubName { get; set; }
    }


}
