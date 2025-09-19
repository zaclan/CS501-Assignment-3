using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeOrderingProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the digital coffee shop!");

            int bill = 0;
            bool done = false;
            do
            {
                Console.WriteLine(
                    "Please make your selection by entering a number:\n"
                    + "1: Small ($2.00)\n"
                    + "2: Medium ($3.00)\n"
                    + "3: Large ($5.00)"
                    );
                string choiceString = Console.ReadLine();
                try
                {
                    int choice = int.Parse(choiceString);
                    switch (choice)
                    {
                        case 1:
                            bill += 2;
                            break;
                        case 2:
                            bill += 3;
                            break;
                        case 3:
                            bill += 5;
                            break;
                        default:
                            throw new FormatException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a valid input.");
                    continue;
                }
                string[] acceptableYes = { "yes", "y", "yeah" };
                string[] acceptableNo = { "no", "n", "nah" };
                do
                {
                    Console.WriteLine("Would you like to order anything else? (yes/no)");
                    string yesOrNo = Console.ReadLine();
                    yesOrNo = yesOrNo.ToLower();
                    if (acceptableYes.Contains(yesOrNo))
                    {
                        break;
                    }
                    else if (acceptableNo.Contains(yesOrNo))
                    {
                        done = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Say that again?");
                    }
                } while (true);
            } while (!done);

            Console.WriteLine("Here's your bill:");
            Console.WriteLine("$" + bill.ToString() + ".00");
            Console.WriteLine("Enter anything to exit.");
            Console.ReadLine();

        }
    }
}
