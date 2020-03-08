using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            double a, b;
            Console.WriteLine("Введите первое число: ");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);
            Console.WriteLine("Введите второе число: ");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);
            double result1 = (a * b);
            double result2 = Math.Pow(result1, 2);
            Console.WriteLine("Результат: " + result2);
        }
    }
}
