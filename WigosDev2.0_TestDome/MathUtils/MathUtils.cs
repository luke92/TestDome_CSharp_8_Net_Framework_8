using System;

namespace MathUtils
{
    public class MathUtils
    {
        public static double Average(int a, int b)
        {
            var sum = a + b;
            var result = (double) sum / 2;
            return result;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(Average(2, 1));
            Console.ReadKey();
        }
    }
}
