using System;

namespace CICDdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Add(5,8));
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
