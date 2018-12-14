using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberSeries = new int[] { 1, 1, 2, 4, 7, 13, 24, 44, 81, 149 };
            for (int i = 0; i < numberSeries.Length; i++)
            {
                Console.WriteLine("Число {0} имеет индекс {1}", numberSeries[i], i);
            }

            Console.WriteLine("Введите индекс по которому хотите найти число последовательности");
            string enterNumber = Console.ReadLine();
            int index = Convert.ToInt32(enterNumber);
            if ((index < 0) || (index > numberSeries.Length - 1))
            {
                Console.WriteLine("Элемента с таким индексом не существует");
            }
            else
            {
                Console.WriteLine("Это число {0}", numberSeries.ElementAt(index));
            }

            Console.ReadKey();
        }

    }
}
