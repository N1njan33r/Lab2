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

            // James - you can define the user input inside of the while loop,
            // also you should initialize this variable the moment you need to use it instead
            // of referencing outside of this scope.
            string userInput;

            // James - I would recommend declaring these variables on 
            // their own lines, and when they are used, that way it
            // becomes clear WHY they even exist, instead of having to
            // to reference this line over and over.
            // Also, is there a reason you are using a decimal? check out...
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/floating-point-types-table
            decimal width, length, height;

            while (true)
            {
                Console.WriteLine("===Enter Width, Length, and Height in Feet===");

                Console.Write("Width:");
                userInput = Console.ReadLine();

                // James - Consider using userInput.Equals(""); as this was 
                // designed to handle string comparison.
                while (userInput == "")
                {
                    // James -not critical, but from a user experience stand point,
                    // consider explaining to the user WHY they need to put 
                    // in the correct width again, always assume the worse
                    // from a user, and help them by educating.
                    Console.Write("Width:");
                    userInput = Console.ReadLine();
                }

                // James - You can just declare the variable here
                // ie.  decimal width = COnvert.ToDecimal(userInput);
                // refer to comments on line 23
                width = Convert.ToDecimal(userInput);

                // James - you do not have to store an empty string in here, if you
                // are going to reuse it, just have the re-used value override 
                // this userInput.
                userInput = "";

                Console.Write("Length:");

                // James - you can have the Console.ReadLine() overrite the new userinput 
                // reference., refer to line 55.
                userInput = Console.ReadLine();

                // James - refer to line 31.
                while (userInput == "")
                {
                    // James - refer to line 43
                    Console.Write("Length:");
                    userInput = Console.ReadLine();
                }

                length = Convert.ToDecimal(userInput);
                // James - refer to line 55.
                userInput = "";

                Console.Write("Height (optional):");
                userInput = Console.ReadLine();
                if (userInput != "")
                {
                    height = Convert.ToDecimal(userInput);
                }
                else
                {
                    height = 0;  // This is a CLEVER solution, I love that you defaulted a value to continue the program
                }

                // James - refer to line 26, this is good! it's good 
                // to just define the variable where you are going to use
                // it, makes it clear to future developers when/why it's being used,
                // and it's being used on the next line!
                decimal area = width * length;

                // James - string concatenating is totally fine, but also check out 
                // string interpolating 
                // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
                Console.WriteLine("Area = " + area);

                // James - nothing wrong with typing out the full "name" of a variable, 
                // for example:  perimeter.  it may seem kind of nit picky but
                // it REALLY makes a difference when you are quick referencing tens of 
                // thousands of lines of code every day.
                decimal peri = 2 * width + 2 * length;
                Console.WriteLine("Perimeter = " + peri);
                if (height != 0)
                {
                    // refer to line 101
                    decimal volu = area * height;
                    Console.WriteLine("Volume = " + volu);
                }

                Console.Write("Would you like to try again? (y/n):");

                // James - I really like that you wrapped the entire program in a while true
                // good stuff!  for cleaner code you can try the inverse here to improve readability.
                //
                //
                //      if(!string.Equals(Console.ReadLine(), "y", StringComparison.OrdinalIgnoreCase))
                //      {
                //          break;
                //      }
                //
                // then you don't have to worry about continuing, because in while(true), to contuniue 
                // is it's default behavior

                if (Console.ReadLine() == "y")
                {
                    continue;
                }

                break;
            }

            Console.WriteLine("Thank you!");
            Console.ReadKey();

            // James -Overall, you solved the problem, just a few cosmetic things and design changes,
            // you could also validate the information but that isn't really necessary for this lab.
            // good stuff, I look forward to grading more of your work :)
        }
    }
}
