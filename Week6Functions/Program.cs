using System;

namespace Week6Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //HelloUser();
            NumberSum();
        }
        public static void HelloUser()
        {
            Console.WriteLine("what's ur name");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}");
        }
        public static void NumberSum()
        {
            Console.WriteLine("number 1");
            int numOne = Int32.Parse(Console.ReadLine());

            Console.WriteLine("number 2");
            int numTwo = Int32.Parse(Console.ReadLine());

            int sum = numOne + numTwo;
            Console.WriteLine($"result = {sum}");
        }
    }
}
