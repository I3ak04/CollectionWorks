using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsWorks
{
    internal class Work1
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> list = new List<int>(100);
            list = AddNumbersToList(list,random);

            Console.WriteLine("\nНажмите любую клавишу, чтобы перейти к числам больше 25, но меньше 50...");
            Console.ReadKey();
            Console.WriteLine("\n");

            WriteRangeNumbers(list);
            Console.ReadKey();
        }

        /// <summary>
        /// Заполняет лист случайными числами
        /// </summary>
        /// <param name="list"></param>
        /// <param name="random"></param>
        /// <returns></returns>
        static List<int> AddNumbersToList(List<int> list, Random random)
        {
            Console.WriteLine("Все случайные числа\n_________________________");
            for (int i = 0; i < 100; i++)
            {
                list.Add(random.Next(0, 101));
                WriteList(i, list);
            }
            
            return list;
        }

       /// <summary>
       /// Выводит в консоль значение определенного индекса листа
       /// </summary>
       /// <param name="index"></param>
       /// <param name="list"></param>
        static void WriteList(int index, List<int> list)
        {
            if ((index + 1) % 5 != 0) Console.Write($"{list[index],3} |");
            else Console.WriteLine($"{list[index],3} |");
        }

        /// <summary>
        /// Выводит в консоль числа определенного диапозона
        /// </summary>
        /// <param name="list"></param>
        static void WriteRangeNumbers(List<int> list)
        {
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 25 && list[i] < 50)
                {

                    WriteList(i,list);
                    count++;
                }
                else continue;
            }
        }
    }
}
