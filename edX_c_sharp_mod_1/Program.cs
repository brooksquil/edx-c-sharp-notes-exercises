using System;

//Creating variables of different data types

namespace edX_c_sharp_mod_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize with a "default" value
            string firstName = "";
            string lastName = "";
            int age = 0;
            string street = "";
            string city = "";
            string country = "";
            DateTime birthDate;

            //Assign some values
            firstName = "Tom";
            lastName = "Thumb";
            age = 18;
            street = "123 Forth Street";
            city = "Anytown";
            country = "USA";
            birthDate = new DateTime(1932, 6, 1);

            // Output to the console window

            // Simple output using only variable name
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            // Placeholder style
            Console.WriteLine("{0} years old.", age);

            // String Concatenation
            Console.WriteLine(street + ", " + city + ", " + country);

            //String Interpolation
            Console.WriteLine($"Born on {birthDate}");
        }
    }
}
