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
            bool retry = true;
            bool inputblank = true;

            while (retry)
            {
                Console.WriteLine("===Enter Width, Length, and Height===");
                do
                {
                    Console.Write("Width (feet):");
                    userInput = Console.ReadLine();

                } while (inputblank);
            }
        }
    }
}
