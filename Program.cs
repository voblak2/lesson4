using System;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetPerson("Emilia");
            GreetPerson("Thomas");
            GreetPerson("Gail");
            GreetPerson("Abraham");
        }

        public static void GreetPerson(string personName)
        {
            Console.WriteLine("Hello " + personName);
        }
    }
}
