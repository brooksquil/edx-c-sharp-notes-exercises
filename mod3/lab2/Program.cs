using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 9;
            int second = 0;
            Console.WriteLine("Enter your first number: ");
            first = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            second = System.Int32.Parse(Console.ReadLine());

            int result = Divide(first, second);
            Console.WriteLine($"The Result of dividing {first} by {second} is {result}");
        }

        //Method Divide() accepts 2 int args and returns the result of dividing first by second
        // We do no validation of the args so a user may pass in a zero
        //if we don't validate input or catch the error, the application will crash
        // add exception handling for divide by 0 exception
            static int Divide(int first, int second)
            {
                int result = 0;
                try
                {
                    result = first / second;
                }
                catch (DivideByZeroException ex)
                {
                    
                   Console.WriteLine("Cannot divide by zero, please provide a non-zero value for your second value");
                } 
                return result;
            }
    }
}
