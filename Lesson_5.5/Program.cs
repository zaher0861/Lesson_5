using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число N, чтобы задать размеры двумерного массива N*N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            bool t = true;
            int[,] array = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j || t==false)
                    {
                        array[i, j] = 1;
                        t = true;
                    }
                    else
                    {
                        array[i, j] = 0;
                        t = false;
                    }
                    Console.Write("{0,4}", array[i, j]);

                }
                Console.WriteLine();
                if (i == N-1)
                {
                    break;
                }
                if (array[i,0] == 0 && i<N-1)
                {
                    array[i + 1, N-N] = 1;
                    t = false;
                }
                else
                {
                    array[i + 1, N-N] = 0;
                    t = true;
                }
            }

            Console.ReadKey();
        }
    }
}
