using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work3
{
    internal class Work3
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int>();

            while(true) 
            {
                Console.WriteLine("Введите число, которое ещё не вводили");
                int inputNumber = int.Parse(Console.ReadLine());
                if(numbers.Contains(inputNumber))
                {
                    Console.WriteLine("Такое число уже есть");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    numbers.Add(inputNumber);
                    Console.WriteLine("Число добавлено");
                    Console.ReadKey();
                    Console.Clear();
                }
                
            }
        }
    }
}
