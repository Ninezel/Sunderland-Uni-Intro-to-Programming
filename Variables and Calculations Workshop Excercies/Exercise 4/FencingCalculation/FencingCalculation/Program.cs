using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FencingCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constant Variables
            const double dCPM = 2.35;

            // Variables
            double dLength;
            double dWidth;

            Console.Write("What is the Length of the field in Metres: ");
            dLength = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the Width of the field in Metres: ");
            dWidth = Convert.ToDouble(Console.ReadLine());

            double dResult = dLength * dWidth * dCPM;
            double dFResult = Math.Round(dResult, 2);

            // Calculation
            Console.WriteLine(" ");
            Console.WriteLine("The price that it will cost you per metre for your field is: " + "£" + dFResult);
            Console.ReadKey();
        }
    }
}
