using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = Input("a=");
            int number2 = Input("b=");
            int number3 = Input("c=");
            int number4 = Input("d=");
            Console.WriteLine($"S={Func(number1, number2) + Func(number3, number4)}");
            Console.ReadLine();
        }
        /// <summary>
        /// Метод ввода значений
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Метод функции
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static int Func(int number1, int number2)
        {
            return number1 > number2 ? number1 : number2;
        }
        
    }
}