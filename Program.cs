using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 > 5 && num1 < 10)
            {
                Console.WriteLine("Число меньше 5 и больше 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
            Console.ReadKey();
        }
    }
}
