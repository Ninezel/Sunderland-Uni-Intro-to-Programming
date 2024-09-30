using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 
            String sName, sProgramme;

            //
            Console.Write("Enter your name: ");

            //
            sName = Console.ReadLine();

            //
            Console.Write("Which programme are you studying: ");

            //
            sProgramme = Console.ReadLine();

            //
            Console.WriteLine("Hello " + sName + " from " + sProgramme);

            //
            Console.WriteLine("Press any key to close.");

            //
            Console.ReadKey();

        }
    }
}
