using System;

namespace DSAlgo
{
    class Program
    {
        public static void Main()
        {
            char[] a = new char[3];
            a[0] = 'a';
            System.Console.WriteLine(a[0]);
            System.Console.WriteLine("Hello");
            IShortAlgos algoProvider = new ShortAlgos();
            uint result = algoProvider.GCD(8, 4);
            System.Console.WriteLine($"8 和 4 的最大公约数是: {result}");
        }
    }
}