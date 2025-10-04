using System;

namespace dotnet_csharp_basic.classes
{
    public class ControlFlow
    {
        public void DemonstrateControlFlow()
        {
            int number = 10;

            // If-Else Statement
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            // Switch Statement
            switch (number)
            {
                case 1:
                    Console.WriteLine("Number is one.");
                    break;
                case 10:
                    Console.WriteLine("Number is ten.");
                    break;
                default:
                    Console.WriteLine("Number is neither one nor ten.");
                    break;
            }

            // For Loop
            Console.WriteLine("For Loop:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // While Loop
            Console.WriteLine("While Loop:");
            int count = 0;
            while (count < 5)
            {
                Console.WriteLine(count);
                count++;
            }

            // Do-While Loop
            Console.WriteLine("Do-While Loop:");
            int doCount = 0;
            do
            {
                Console.WriteLine(doCount);
                doCount++;
            } while (doCount < 5);

            // Foreach Loop
            Console.WriteLine("Foreach Loop:");
            string[] fruits = { "Apple", "Banana", "Cherry" };
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}