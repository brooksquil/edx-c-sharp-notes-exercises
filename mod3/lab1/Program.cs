using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sum(20, 40);

            int result = Sum(20, 40);
            Console.WriteLine($"The sum of 20 and 40 is {result}");

            int result3 = Sum(10, 50, 80);
            Console.WriteLine($"Calling Sum() with 3 args, result is: {result3}");

            double dblResult = Sum(20.5, 30.6);
            Console.WriteLine($"Calling Sum() that takes result in: {dblResult}");
        }
        // VOID
        // // Sum() method that takes two integer arguments and sums them
        // // The method returns no value which is why we use void
        // // We also need to use static in the method signature bc main is static
        // // a non-static method cannot be called from a static one

            // static void Sum(int first, int second)
            // {
            //     int sum = first + second;
            //     Console.WriteLine($"The sum of {first} and {second} is: {sum}");
            // }
        // //////////////////////////////////////////////
        // INT
        // Sum() method that takes two integer arguments and sums them
        // The method returns an integer value which is why we use int in the signature
        // We also need to use static in the method signature because main is static
        // And you cannot call a non-static method from a static method
            static int Sum(int first, int second)
            {
                int sum = first + second;
                return sum;
            }
        // //////////////////////////////////////////
        // OVERLOADING
        // 3 parameters
        // Sum() method that takes three integer arguments and sums them and then returns the value
        // This method uses the same name as the Sum() method that takes two integers
        // The parameters here indicate the method is expecting three integers as arguments
        // The compiler knows which method to call based on the number of arguments passed in
            static int Sum(int first, int second, int third)
            {
                int sum = first + second + third;
                return sum;
            }

        // 2 Doubles
        // Sum() method that takes two doubles as arguments
        // Uses same name as Sum() with 2 int
        // these parameters expect 2 doubles
        // Compiler calls method based on data types
            static double Sum(double first, double second)
            {
                double result = first + second;
                return result;
            }
         

    }
}
