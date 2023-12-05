using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double E = 0.001;
            double A, S;
            int N;
            Console.Write("Введите x=");
            double x = double.Parse(Console.ReadLine());
            S = 0;
            N = 0;
            A = x / 3;
            do
            {
                S += A;
                N++;
                A = A * 2 / ((2 * N + 3) * (2 * N + 2));
            } while (A >= E);
            Console.WriteLine($"Сумма членов ряда S = {S,8:f4}, число интераций N = {N}");
            Console.ReadKey();
        }
    }
}
