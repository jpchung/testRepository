using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static int RandomNum()
        {
            Random rand = new Random();
            int randInt = rand.Next(1, 11); //inclusive upperbound
            Console.WriteLine("Generating random number between 1 and 10");

            return randInt;

        }

        public static void RandGuess(int randInt)
        {
            string guess;
            int guessInt = 0;

            do
            {
                Console.WriteLine("Guess the number");
                guess = Console.ReadLine();
                //try to parse string to int output
                bool intInput = Int32.TryParse(guess, out guessInt);
                if (intInput == false)
                {
                    Console.WriteLine("Invalid input, must be an integer. Try again...");
                }
                else if (guessInt != randInt)
                {
                    Console.WriteLine("Incorrect guess. Try again...");
                }
            } while (guessInt != randInt);

            Console.WriteLine("Correct! Good guess!");
        }
        static void Main(string[] args)
        {
            //comment

            /*
             * multiline comment
             */

            Console.WriteLine("Hello World!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);


            int maxInt = int.MaxValue;

            Console.WriteLine("Max int: " + maxInt);

            //var data type is defined at compile time, can't change 
            var anotherName = "Tom";

            Console.WriteLine("Another name is {0}, and its type is {1}", anotherName, anotherName.GetTypeCode());

            //int i = 0;
            //Console.WriteLine("i = " + i);incrementing
            //Console.WriteLine("i++ = " + (i++)); //retrieves i = 0  before  to i = 1
            //Console.WriteLine("++i = " + (++i)); //increments i = 1 to i = 2 and then retrieves for print

            //type casting
            double pi = 3.14;
            Console.WriteLine("double pi = " + pi);

            int intPi = (int)pi;
            Console.WriteLine("int pi = " + intPi);

            //generate random number 1-10
            int randInt = RandomNum();

            bool lessThan5 = randInt < 5 ? true : false;

            Console.WriteLine("Less than 5? " + lessThan5);

            Console.WriteLine("Switch based on randInt:");
            switch (randInt)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("1-3");
                    goto endSwitch;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("4-6");
                    goto endSwitch;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("7-9");
                    goto endSwitch;
                case 10:
                    Console.WriteLine("10");
                    goto endSwitch;

            }

        endSwitch:
            RandGuess(randInt);

            //generate another random number
            Console.WriteLine("Generating a new number...");
            int randInt2 = RandomNum();

            Console.WriteLine("Counting to random number...");

            int i;
            for (i = 0; i < randInt2; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("The number is " + i);

            string randString;
            do
            {
                Console.WriteLine("Enter a random string:");
                randString = Console.ReadLine();

                if (String.IsNullOrEmpty(randString))
                {
                    Console.WriteLine("You didn't write anything...");
                }

            } while (String.IsNullOrEmpty(randString));



            int charValue;
            foreach (char c in randString)
            {
                charValue = (int)c;


                Console.WriteLine("The ASCII value for " + c + " is " + charValue);
            }



            Console.WriteLine("Press Enter to end program...");
            Console.ReadLine();
        }


    }
}
