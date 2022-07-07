using System;

namespace CandU224A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int X = Convert.ToInt16(Console.ReadLine());

            Class224A.MathOne(X);

            Class224A.MathTwo(out string Duck);

            Console.WriteLine("Please enter a number");
            int Y = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please enter a number");
            int Z = Convert.ToInt16(Console.ReadLine());

            Class224A.MathOne(X, Y, Z);

        }
    }
}
