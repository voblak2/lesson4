using System;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Welcome();
            NewMethod();
        }

        public static void Welcome()
        {
            Console.WriteLine("Welcome to Earth!");
        }

        public static void NewMethod()
        {
            Console.WriteLine("I hope this works!");
        }
    }
}
