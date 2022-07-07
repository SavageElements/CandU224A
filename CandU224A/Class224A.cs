using System;
using System.Collections.Generic;
using System.Text;

namespace CandU224A
{
    class Class224A
    {
        public static void MathOne(int X)
        {

            int Answer = (X / 2);
            Console.WriteLine("Your input divided by two as an int");
            Console.WriteLine(Answer);
        }

        public decimal  Y;

        public int DUCK;
        public static void MathTwo (out string DUCK)
        {
            DUCK = "The output string is Duck";
            Console.WriteLine(DUCK);

        }

        public static void MathOne(int X, int Y, int Z)
        {

            int Answer = ((X / 2) + Y + Z);
            Console.WriteLine("Your original input divided by two, plus the nuext two numbers you entered equals");
            Console.WriteLine(Answer);
        }

    }
}
