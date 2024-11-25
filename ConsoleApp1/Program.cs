using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// вычисление
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// точка ввода в программу
        /// </summary>
        /// <param name="args">строковый массив</param>
        static void Main(string[] args)
        {
            double y = Fune(5,7) + Fune(12,8) + Fune(19,2);
            Console.WriteLine($"y={y}");
            Console.ReadKey();
        }
        public static double Fune(int x, int z)
        {
            return (Math.Sqrt(x) + x / Math.Sqrt(z) + z);
        }
       
    }
}