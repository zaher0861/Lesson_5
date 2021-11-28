using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[7];
            Console.WriteLine("Введите любое число: ");
            array[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите любое число: ");
            array[1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите любое число: ");
            array[2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите любое число: ");
            array[3] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите любое число: ");
            array[4] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите любое число: ");
            array[5] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите любое число: ");
            array[6] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ваш массив: ");
            double Sum = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.Write("{0} ", array[i]);
                Sum += array[i];
            }
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое значение чисел в массиве = {0:f3}", Sum/7);
            Console.ReadKey();
        }
    }
}
