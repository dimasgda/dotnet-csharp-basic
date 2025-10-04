using System;

namespace dotnet_csharp_basic.classes
{
    public class Operator
    {
        internal void DemonstrateOperators()
        {
            int a = 10;
            int b = 20;

            // Arithmetic Operators
            Console.WriteLine($"Addition: {a + b}");
            Console.WriteLine($"Subtraction: {a - b}");
            Console.WriteLine($"Multiplication: {a * b}");
            Console.WriteLine($"Division: {b / a}");
            Console.WriteLine($"Modulus: {b % a}");

            // Comparison Operators
            Console.WriteLine($"Equal: {a == b}");
            Console.WriteLine($"Not Equal: {a != b}");
            Console.WriteLine($"Greater Than: {a > b}");
            Console.WriteLine($"Less Than: {a < b}");
            Console.WriteLine($"Greater Than or Equal: {a >= b}");
            Console.WriteLine($"Less Than or Equal: {a <= b}");

            // Logical Operators
            bool x = true;
            bool y = false;
            Console.WriteLine($"Logical AND: {x && y}");
            Console.WriteLine($"Logical OR: {x || y}");
            Console.WriteLine($"Logical NOT: {!x}");
        }
    }
}