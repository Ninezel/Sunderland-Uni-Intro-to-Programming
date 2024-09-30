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
            // We are Declaring String Variables Here
            String sName, sProgramme;

            // We are calling on the Console to Allow the User to Input into the Console
            Console.Write("Enter your name: ");

            // Whatever the user input into the console it will be saved into the string sName variable
            sName = Console.ReadLine();

            // We are calling on the console again to get information from the user
            Console.Write("Which programme are you studying: ");

            // We are storing that value into the sProgramme string
            sProgramme = Console.ReadLine();

            // We are now outputting to the console the answer that we have gathered
            Console.WriteLine("Hello " + sName + " from " + sProgramme);

            // We are notifying the user that they can press any key to close the console
            Console.WriteLine("Press any key to close.");

            // This is the end of the code, any key pressed by the user will close the console
            Console.ReadKey();

        }
    }
}
