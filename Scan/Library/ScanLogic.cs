using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class ScanLogic
    {
           
        public static List<string> Scan (string dirName)
        {
 
            List<string> allFolders = new List<string>(Directory.EnumerateDirectories(dirName));

            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Catalogs:");

                foreach (var s in allFolders)
                {
                   
                    allFolders.AddRange(Scan(s));
                }

                Console.WriteLine("Files:");
                string[] files = Directory.GetFiles(dirName);

                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
            return allFolders;
        }

    }
}
