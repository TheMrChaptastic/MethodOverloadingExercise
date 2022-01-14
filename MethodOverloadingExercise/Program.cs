using System;

namespace MethodOverloadingExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 4));
            Console.WriteLine(Add(2.2m, 4.3m));
            Console.WriteLine(Add(5, 12, true));
            Console.WriteLine(Add(2, 2, false));
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        static string Add(int a, int b, bool c)
        {
            return c ? $"{a + b} dollars" : "1 dollar";
        }
    }
}
