using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void PrintMatchingLines(string file, string str)
        {
            if (!File.Exists(file))
                return;
            foreach (string line in File.ReadAllLines(file))
                if (line.IndexOf(str) != -1)
                    Console.WriteLine("{0}: {1}", file, line);
        }
        static void Recurse(string folder, string str)
        {
            if (!Directory.Exists(folder))
                return;
            foreach (string dir in Directory.GetDirectories(folder))
                Recurse(dir, str);
            foreach (string file in Directory.GetFiles(folder))
                PrintMatchingLines(file, str);
        }
        static void Main(string[] args)
        {
            string folder = args[0];
            string str = args[1];
            Recurse(folder, str);
            Console.ReadKey();
        }
    }
}
