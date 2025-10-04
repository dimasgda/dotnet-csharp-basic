using dotnet_csharp_basic.classes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("C# Data Types:");
        DataType dataType = new DataType();
        dataType.DisplayDataTypes();

        Console.WriteLine("\n C# Methods:");
        Method method = new Method();
        method.PrintHello();
        Console.WriteLine($"Random Number: {method.GetRandomNumber()}");
        method.PrintMessage("This is a custom message.");
        Console.WriteLine($"Sum: {method.AddNumbers(5, 10)}");
        method.Greet();
        method.Greet("Alice");
        Console.WriteLine($"Sum of Numbers: {method.SumNumbers(1, 2, 3, 4, 5)}");

        Console.WriteLine("\n C# Control Flow:");
        ControlFlow controlFlow = new ControlFlow();
        controlFlow.DemonstrateControlFlow();

        Console.WriteLine("\n C# Exception Handling:");
        ExceptionHandler exceptionHandler = new ExceptionHandler();
        exceptionHandler.DemonstrateExceptionHandling();
    }
}