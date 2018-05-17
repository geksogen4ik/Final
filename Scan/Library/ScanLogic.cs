using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Library
{
    public static class ScanLogic
    {
        public static void Scan(object dirName)
        {
            var newDirName = dirName.ToString();

            if (Directory.Exists(newDirName))
            {
                try
                {
                    Console.WriteLine(dirName);

                    foreach (var s in Directory.GetDirectories(newDirName))
                    {
                        var delegateNew = new ParameterizedThreadStart(Scan);

                        Thread thread = new Thread(delegateNew);

                        thread.Start(s);
                    }
                }

                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("Access Expention");
                }

            }
        }
    }
}
   