using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_S_Cube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Площадь куба S = {0}м2, объем куба V = {1}м3", CalcCube1(a), CalcCube2(a));
            Console.ReadKey();
        }
        static double CalcCube1(int a)
        {
            double S = Math.Pow(a,2);
            return S;
        }
        static double CalcCube2(int a)
        {
            double V = Math.Pow(a, 3);
            return V;
        }
    }
}
