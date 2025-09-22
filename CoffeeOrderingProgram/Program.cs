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

            int bill = 0;   //total price
            bool done = false;  //whether or not the person is still ordering
            
            //let them order once, then keep prompting to order again and looping through until they stop.
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
                    //if they don't give valid input, the next iteration starts and just prompts them again
                    Console.WriteLine("Not a valid input.");
                    continue;
                }
                //Some viable response values.
                string[] acceptableYes = { "yes", "y", "yeah" };
                string[] acceptableNo = { "no", "n", "nah" };
                //Whithin this loop, make another loop to run until the user properly confirms/denies a new order.
                do
                {
                    Console.WriteLine("Would you like to order anything else? (yes/no)");
                    string yesOrNo = Console.ReadLine();
                    yesOrNo = yesOrNo.ToLower();
                    //regardless of yes or no, break this response loop when a valid response is given.
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
