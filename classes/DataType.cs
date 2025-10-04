using System;

namespace dotnet_csharp_basic.classes
{
    public class DataType
    {
        int myInt = 10;
        float myFloat = 20.5f;
        double myDouble = 30.5;
        char myChar = 'A';
        string myString = "Hello";
        bool myBool = true;
        decimal myDecimal = 100.5m;
        long myLong = 123456789L;
        byte myByte = 255;
        short myShort = 32767;
        uint myUInt = 4294967295;
        ulong myULong = 18446744073709551615;
        sbyte mySByte = 127;
        ushort myUShort = 65535;
        DateTime myDateTime = DateTime.Now;


        public void DisplayDataTypes()
        {
            Console.WriteLine("Integer: " + myInt);
            Console.WriteLine("Float: " + myFloat);
            Console.WriteLine("Double: " + myDouble);
            Console.WriteLine("Character: " + myChar);
            Console.WriteLine("String: " + myString);
            Console.WriteLine("Boolean: " + myBool);
            Console.WriteLine("Decimal: " + myDecimal);
            Console.WriteLine("Long: " + myLong);
            Console.WriteLine("Byte: " + myByte);
            Console.WriteLine("Short: " + myShort);
            Console.WriteLine("Unsigned Integer: " + myUInt);
            Console.WriteLine("Unsigned Long: " + myULong);
            Console.WriteLine("Signed Byte: " + mySByte);
            Console.WriteLine("Unsigned Short: " + myUShort);
            Console.WriteLine("DateTime: " + myDateTime);
        }
    }
}