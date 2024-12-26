using System;

namespace IfElse
{
    class IfAssignment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 10)
            {
                Console.WriteLine("The number is equal to 10");
            }
            else if (number < 10)
            {
                Console.WriteLine("The number is less than 10");
                if (number % 2 == 0)
                {
                    Console.WriteLine("It's an even number");
                }
                else
                {
                    Console.WriteLine("It's an odd number");
                }
            }
            else
            {
                Console.WriteLine("The number is greater than 10");
                if (number % 2 == 0)
                {
                    Console.WriteLine("It's an even number");
                }
                else
                {
                    Console.WriteLine("It's an odd number");
                }
            }
        }
    }
}