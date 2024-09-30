using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring Variables
            int iNumCrisps = 10;
            int iCount;

            Console.WriteLine("Hello, we currently have " + iNumCrisps + " crisp packets available!");
            Console.Write("Please enter a number on how many packets will you like to take out: ");
            iCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You have taken " + iCount);

            int iAvailable = iNumCrisps - iCount;
            Console.WriteLine("There are currently " + iAvailable + " packet of crisps left!");
            Console.ReadKey();
        }
    }
}
