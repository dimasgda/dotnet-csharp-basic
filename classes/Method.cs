using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_csharp_basic.classes
{
    public class Method
    {
        // Method without return type and without parameters
        public void PrintHello()
        {
            Console.WriteLine("Hello, World!");
        }

        // Method with return type and without parameters
        public int GetRandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 100);
        }

        // Method without return type and with parameters
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        // Method with return type and with parameters
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        // Method with optional parameters
        public void Greet(string name = "Guest")
        {
            Console.WriteLine($"Hello, {name}!");
        }

        // Method with params keyword
        public int SumNumbers(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}