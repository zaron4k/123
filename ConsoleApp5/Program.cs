using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта без параметров
            Calculate calc = new Calculate();
            calc.Output();
            Console.WriteLine(calc.ToString());

            // Изменение значений полей
            calc.Field_1 = 3;
            calc.Field_2 = -10;
            Console.WriteLine(calc.ToString());

            // Создание объекта с одним параметром
            Calculate calc_1 = new Calculate(4);
            calc_1.Output();

            // Создание объекта с двумя параметрами
            Calculate calc_2 = new Calculate(2, 3);
            calc_2.Output();
            calc_2.Func();

            // Создание объекта с parsed значением (передаем значение для field_1 и Field_2)
            string input = "5";  // Пример входных данных
            double field_1 = double.Parse(input);
            Calculate c = new Calculate(field_1, field_1);

            Console.Read();
        }
        }
    }
