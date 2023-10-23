using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaclGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b; 
            Console.WriteLine("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите действие из предложенных: +, -, *, /");
            string action = Convert.ToString(Console.ReadLine());   

            switch (action)
            {
                case "+": 
                    Console.WriteLine("Ответ: " + (a + b));
                    break;
                case "-":
                    Console.WriteLine("Ответ: " + (a - b));
                    break;
                case "*":
                    Console.WriteLine("Ответ: " + (a * b));
                    break;
                case "/":
                    Console.WriteLine("Ответ: " + (a / b));
                    break;
            }
        }
    }
}
