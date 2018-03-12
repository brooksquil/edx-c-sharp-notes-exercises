using System;

namespace mod2_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // /////////////
            // For Loop
            // /////////////
            // Create a simple for loop that displays the values of the counter
            // The WriteLine method here demonstrates the use of string interpolation in C#
            // as a way of outputting literal string values with variable values.
            // It is the recommended way to deal with this method of string output
            // for(int counter = 0; counter < 10; counter++)
            // {
            //     Console.WriteLine($"Counter is at: {counter}"); 
            // }

            // //////////////////
            // while loop
            // //////////////////
            // Create a while loop
            // start with n = 1
            // the condition check for the while , test if n is less than 6, if so, the loop body code executes
            // inside the loop, output the value of n and then increment by 1
            // Once n = 6, the loop stops
            // Pay attention to the output to see what the last value is
            // int n = 1;
            // while (n < 6)
            // {
            //     Console.WriteLine($"Current value of n is {n}");
            //     n++;
            // }

            // //////////////
            // do loop
            // //////////////
            // The loop will run at least once regardless of the value of x
            // The loop runs once because the value is checked at the end of the loop
            int x = 8;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 5);

        }
    }
}
