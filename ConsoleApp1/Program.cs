using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// вычисление функции
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// метод ввода
        /// </summary>
        /// <param name="args">строковый параметр</param>
        /// <returns></returns>
       public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static double Fune(int number1, int number2)
        {
            return number1 > number2 ? number1 : number2;

        }

        static void Main(string[] args)
        {
            int number1 = Input("Введите первое число: ");
            int number2 = Input("Введите второе число: ");
            Console.WriteLine($"Наибольшее число: {Fune(number1, number2)}");
            Console.ReadKey();
        }
    }
}
