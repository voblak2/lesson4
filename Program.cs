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
            ForRealBro();
        }

        public static void Welcome()
        {
            Console.WriteLine("Welcome to Earth!");
        }

        public static void NewMethod()
        {
            Console.WriteLine("I hope this works!");
        }

        public static void ForRealBro()
        {
            Console.WriteLine("Man, I love me some C#!");
        }
    }
}
