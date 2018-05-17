using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Library;

namespace Scan
{
    class Program
    {


        static void Main(string[] args)
        {
    
            Console.WriteLine("Enter the catalog's name, please");
            try
            {
                string dirName = Console.ReadLine();
                ScanLogic.Scan(dirName);
            }
            catch (IOException)
            {
                Console.WriteLine("I/O error");
            }
            catch(OutOfMemoryException)
            {
                Console.WriteLine("Memory is full");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Symbols amoun grater then MaxValue");
            }

        }

        
    }
   
}
    

       
    

    
        
    

