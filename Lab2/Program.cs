using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Perimeter Discovery Central");

            string userInput;
            decimal width, length, height;

            while (true)
            {
                Console.WriteLine("===Enter Width, Length, and Height in Feet===");

                Console.Write("Width:");
                userInput = Console.ReadLine();
                while (userInput == "")
                {
                    Console.Write("Width:");
                    userInput = Console.ReadLine();
                }

                width = Convert.ToDecimal(userInput);
                userInput = "";

                Console.Write("Length:");
                userInput = Console.ReadLine();
                while (userInput == "")
                {
                    Console.Write("Length:");
                    userInput = Console.ReadLine();
                }

                length = Convert.ToDecimal(userInput);
                userInput = "";

                Console.Write("Height (optional):");
                userInput = Console.ReadLine();
                if (userInput != "")
                {
                    height = Convert.ToDecimal(userInput);
                }
                else
                {
                    height = 0;
                }

                decimal area = width * length;
                Console.WriteLine("Area = " + area);
                decimal peri = 2 * width + 2 * length;
                Console.WriteLine("Perimeter = " + peri);
                if (height != 0)
                {
                    decimal volu = area * height;
                    Console.WriteLine("Volume = " + volu);
                }

                Console.Write("Would you like to try again? (y/n):");
                if (Console.ReadLine() == "y")
                {
                    continue;
                }

                break;
            }

            Console.WriteLine("Thank you!");
            Console.ReadKey();
        }
    }
}
