using System;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;

            // store the returned value of the "add" method.
            int sum = Add(num1, num2);
            Console.WriteLine(sum);
        }

        // add method returns an integer.
        public static int Add(int number1, int number2)
        {
            return (number1 + number2);
        }
    }
}