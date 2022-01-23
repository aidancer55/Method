using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int z1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int z2 = Convert.ToInt32(Console.ReadLine());
            double S1 = CalcSqr1(x1, y1, z1, out S1);
            double S2 = CalcSqr2(x2, y2, z2, out S2);
            Console.WriteLine("Площадь первого треугольника {0}м2, площадь второго треугольника {1}м2", S1, S2);
            if (S1==S2)
            {
                Console.WriteLine("Площади треугольников равны, S={0}м2", S1);
            }
            else if (S1>S2)
            {
                Console.WriteLine("Площадь большего треугольника {0}м2", S1);
            }
            else
            {
                Console.WriteLine("Площадь большего треугольника {0}м2", S2);
            }
            Console.ReadKey();

        }
        static double CalcSqr1(int x1, int y1, int z1, out double S1)
        {
            double p = (x1 + y1 + z1) / 2;
            S1 = Math.Round(Math.Sqrt(p * (p - x1) * (p - y1) * (p - z1)), 1);
            return S1;
        }
        static double CalcSqr2(int x2, int y2, int z2, out double S2)
        {
            double p = (x2 + y2 + z2) / 2;
            S2 = Math.Round(Math.Sqrt(p * (p - x2) * (p - y2) * (p - z2)), 1);
            return S2;
        }
    }
}
