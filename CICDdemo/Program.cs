using System;

namespace CICDdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Add(5,8));
            Console.WriteLine(Add(5,8));
            Console.WriteLine(Sub(10,5));
            Console.WriteLine(Sub(10,5));
            Console.WriteLine(Sub(10,5));
            Console.WriteLine(Sub(10,5));
            Console.WriteLine(Sub(10,5));
            Console.WriteLine(Sub(10,5));
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
