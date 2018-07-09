using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int x = Int32.Parse(Console.ReadLine());
            doIntMath y = new doIntMath();
            Console.WriteLine(y.addMath(x));
            Console.WriteLine(y.minusMath(x));
            Console.WriteLine(y.DivideMath(x));
            Console.ReadLine();
        }
    }
}