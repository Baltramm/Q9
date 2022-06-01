using System;

namespace Q9
{
    class Program
    {
        delegate int Funcd(int a, int b);
        public static int func(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            Funcd funcd = func;
            Console.WriteLine(funcd.Invoke(10, 5));
        }

        

        
    }
}
