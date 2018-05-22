using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateCookbook.Tools
{
    class Program
    {
        static IDictionary<String, Action> sub = GetCmdlineDict();
        static void Main(string[] args)
        {

            Options options;
            if (!Parser.TryParse<Options>(args, out options))
            {
                return;
            }
            else
            {
                if (sub.ContainsKey(options.SubName))
                {
                    sub[options.SubName].Invoke();
                }
                else
                {
                    Console.WriteLine($"{options.SubName} is not a valid sub program ");
                }
            }
            //NHDBGen.UdpateDatabase();
        }

        static IDictionary<String, Action> GetCmdlineDict()
        {
            Dictionary<String, Action> dict = new Dictionary<string, Action> {
                { "all", Program.ShowAll},
                { "update", NHDBGen.UdpateDatabase}
            };
            return dict;
        }

        static void ShowAll()
        {
            foreach (KeyValuePair<String, Action> kvp in sub)
            {
                Console.WriteLine(kvp.Key);
            }
        }
    }
}
