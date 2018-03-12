using System;

namespace mod2_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 9; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("XOXOXOXO");
                }
                else
                {
                    Console.WriteLine("OXOXOXOX");
                }
            }
        }
    }
}
