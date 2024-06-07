using System;

namespace debug_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double h = 0.05;
            int n = 10;

            while (x <= 1 + h)
            {
                double y = (1 + 2 * x * x) * Math.Exp(x * x);
                double s = (1 + 2 * x * x);
                for (int i = 1; i <= n; i++)
                {
                    double slag = Math.Pow(x, i * 2) / Factorial(i);
                    s += (1 + 2 * x * x) * slag;
                }
                Console.WriteLine("| {0}\t| {1}\t| {2}\t|\n", Math.Round(x, 6), Math.Round(y, 6), Math.Round(s, 6));
                x += h;
            }
        }

        static int Factorial(int n)
        {
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
