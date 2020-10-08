using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamsSum(5, 5);
        }
        public static void ParamsSum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
        public static void StringFunction()
        {
            Console.WriteLine("enter string:");
            string functionString = Console.ReadLine();
            Console.WriteLine(functionString);
        }
    }
}
