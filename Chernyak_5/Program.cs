using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernyak_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнила Черняк Оксана Александровна, АЭМ-111");
            string[] tokens = Console.ReadLine().Split(' ');
            int[] array = new int[tokens.Length];
            for (int i = 0; i < tokens.Length; i++)
            {
                array[i] = int.Parse(tokens[i]);
            }

            if (array.Length < 3)
            {
                Console.WriteLine("Количество элементов < 3, троек не существует.");
            }
            else
            {
                int max1 = -10000, max2 = -10000, max3 = -10000;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > max1)
                    {
                        max3 = max2;
                        max2 = max1;
                        max1 = array[i];
                    }
                    else if (array[i] > max2)
                    {
                        max3 = max2;
                        max2 = array[i];
                    }
                    else if (array[i] > max3)
                    {
                        max3 = array[i];
                    }
                }

                Console.WriteLine("Тройка наибольших чисел: {0}, {1}, {2}", max1, max2, max3);
            }
            Console.ReadKey();
        }
    }
}