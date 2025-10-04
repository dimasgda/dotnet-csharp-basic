using System;

namespace dotnet_csharp_basic.classes
{
    public class ExceptionHandler
    {
        public void DemonstrateExceptionHandling()
        {
            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[5]); // This will throw an exception
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Caught an IndexOutOfRangeException: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught a general exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("This block always executes.");
            }
        }
    }
}