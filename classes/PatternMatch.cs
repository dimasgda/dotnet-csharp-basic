using System;

namespace dotnet_csharp_basic.classes
{
    public class PatternMatch
    {
        object value = "string";

        internal void Test()
        {
            // Pattern matching with 'is' keyword
            if (value is int intValue)
            {
                Console.WriteLine($"It's an integer: {intValue}");
            }
            else if (value is string strValue)
            {
                Console.WriteLine($"It's a string: {strValue}");
            }
            else
            {
                Console.WriteLine("It's of an unknown type.");
            }
        }
    }
}