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
        public static double Fune(int number1, int number2, int number3)
        {
            return number1 > number2 ? number1 : number2;
            return number2 > number3 ? number2 : number3;
            return number1 > number3 ? number1 : number3;
        }

        static void Main(string[] args)
        {
            int number1 = Input("Введите первое число: ");
            int number2 = Input("Введите второе число: ");
            int number3 = Input("Введите третье число: ");
            Console.WriteLine($"Наибольшее число: {Fune(number1, number2, number3)}");
            Console.ReadKey();
        }
    }
}