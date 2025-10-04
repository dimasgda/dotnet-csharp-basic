using System;

namespace dotnet_csharp_basic.classes
{
    public class Convertion
    {
        public void DemonstrateConvertion()
        {
            // Implicit Conversion
            int intValue = 10;
            double doubleValue = intValue; // Implicit conversion from int to double
            Console.WriteLine($"Implicit Conversion: {doubleValue}");

            // Explicit Conversion
            double anotherDoubleValue = 9.78;
            int anotherIntValue = (int)anotherDoubleValue; // Explicit conversion from double to int
            Console.WriteLine($"Explicit Conversion: {anotherIntValue}");

            // Using Convert class
            string stringValue = "123";
            int convertedValue = Convert.ToInt32(stringValue);
            Console.WriteLine($"Convert Class: {convertedValue}");
        }
    }
}