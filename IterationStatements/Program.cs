using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintRange() 
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintByThree() 
        {
            for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void EqualParams(int num1, int num2) 
        {
            //num1 == num2 ? Console.WriteLine("These are equal.") : Console.WriteLine("These do not equal.");
            if (num1 == num2)
            {
                Console.WriteLine("These are equal.");
            }
            else 
            {
                Console.WriteLine("These are not equal.");
            }
        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int number) 
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("This number is even.");
            }
            else 
            {
                Console.WriteLine("This number is odd.");
            }
        }
        //Write a method to check whether a given number is positive or negative
        public static void PosOrNeg(int number) 
        {
            if (number < 0)
            {
                Console.WriteLine("This number is negative.");
            }
            else 
            {
                Console.WriteLine("This number is positive.");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void VotingAge() 
        {
            Console.WriteLine("Please enter your current age.");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("It is now your civic duty to vote.");
            }
            else 
            {
                Console.WriteLine("Please be registered and ready to vote on your 18th birthday!");
            }

        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void IntRange() 
        {
            Console.WriteLine("Is your number within range? Enter one and find out.");
            int number = int.Parse(Console.ReadLine());
            if (number >= -10 && number <= 10)
            {
                Console.WriteLine("Nice! You guessed within the range.");
            }
            else 
            {
                Console.WriteLine("Sorry, please try again.");
            }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultTable() 
        {
            int x, y;

            Console.WriteLine();
            Console.WriteLine("Display Multiplication Table:");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            Console.Write("Input a number ('1' - '12') : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (x = 1; x <= 12; x++)
            {
                Console.WriteLine("{0} X {1} = {2}", y, x, y * x);
            }
        
    }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //PrintRange();  
            //PrintByThree(); 
            //EqualParams(1, 2);
            //EvenOrOdd(3);
            //PosOrNeg(-1);
            //VotingAge();
            //IntRange();
            MultTable();
        }
    }
}
