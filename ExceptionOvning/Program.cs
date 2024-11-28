using System;

namespace ExceptionOvning
{
    internal class Program
    {
        public static void HandleMultipleExceptions(string text, int index)
        {
            int[] numbersArray = { 67, 14, 38, 25 };

            try
            {
                int parsedString = int.Parse(text);
                int result = numbersArray[index];
                Console.WriteLine(result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Result without exception");
            HandleMultipleExceptions("1", 1);
            
            Console.WriteLine("\nResult with \"index out of range\" exception");
            HandleMultipleExceptions("3", 9);

            Console.WriteLine("\nResult with \"invalid format\" exception");
            HandleMultipleExceptions("hej", 2);
        }
    }
}
