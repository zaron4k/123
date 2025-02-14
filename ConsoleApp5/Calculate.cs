using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{/// <summary>
/// класс Calculate
/// </summary>
    class Calculate
    {
  
     
            private double field_1;
            private double field_2;

            public double Field_1 { get => field_1; set => field_1 = value; }
            public double Field_2 { get => field_2; set => field_2 = value; }
        
            /// <summary>
            /// Конструктор по умолчанию
            /// </summary>
            public Calculate() { }

            /// <summary>
            /// Конструктор с 1 параметром
            /// </summary>
            /// <param name="field_1">Поле 1</param>
            public Calculate(double field_1)
            {
                this.Field_1 = field_1;
            }

            /// <summary>
            /// Конструктор с 2 параметрами
            /// </summary>
            /// <param name="field_1">Поле 1</param>
            /// <param name="field_2">Поле 2</param>
            public Calculate(double field_1, double field_2)
            {
                this.Field_1 = field_1;
                this.Field_2 = field_2;
            }

            /// <summary>
            /// Метод для вывода значений полей.
            /// </summary>
            public void Output()
            {
                Console.WriteLine($"field1={Field_1}, field2={Field_2}");
            }

            /// <summary>
            /// Метод для вычисления квадратного корня из произведения полей
            /// </summary>
            public double CalculateSquareRoot()
            {
                if (Field_1 < 0 || Field_2 < 0)
                {
                    throw new ArgumentException("Значения полей не могут быть отрицательными для вычисления квадратного корня.");
                }
                return Math.Sqrt(Field_1 * Field_2);
            }

            /// <summary>
            /// Метод для преобразования объекта в строку
            /// </summary>
            public override string ToString()
            {
                return $"Calculate: Field_1 = {Field_1}, Field_2 = {Field_2}";
            }

            /// <summary>
            /// Метод, который необходимо реализовать
            /// </summary>
            internal void Func()
            {
                // Реализовать функциональность метода здесь.
                throw new NotImplementedException("Этот метод пока не реализован.");
            }
        }

    }


