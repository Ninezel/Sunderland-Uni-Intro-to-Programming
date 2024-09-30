using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmailSignature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constant Variables
            const string sADDRESS = "David Goldman Informatics Centre St Peter's Way \nSunderland SR6 0DD";
            const string sFACULTY = "Faculty of Technology";

            // The Beginning of the Program that will make the console wait 5 seconds
            Console.Write("Email Signature Creation Software");
            Thread.Sleep(5000);
            Console.Clear();

            // User input declaring the variables
            Console.Write("Please Input Your Full Name: ");
            string sStaffName = Console.ReadLine();
            Console.Write("Please Enter the Room Number: ");
            string sRoomNumber = Console.ReadLine();
            Console.Write("Please Enter Your Email Address: ");
            string sStaffEmail = Console.ReadLine();

            // User output of results
            Console.Clear();
            Console.WriteLine(sStaffName);
            Console.WriteLine(" ");
            Console.WriteLine(sFACULTY);
            Console.WriteLine(sRoomNumber);
            Console.WriteLine(sADDRESS);
            Console.WriteLine(" ");
            Console.WriteLine(sStaffEmail);
            Console.ReadKey();
        }
    }
}
