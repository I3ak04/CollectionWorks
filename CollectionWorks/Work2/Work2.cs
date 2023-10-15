using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work2
{
    internal class Work2
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> phoneBook = new Dictionary<string, string>();
            phoneBook = AddPhones(phoneBook);
            FindByPhoneNumber(phoneBook);
            
        }

        /// <summary>
        /// Найходит владельца по номеру телефона
        /// </summary>
        /// <param name="phoneBook"></param>
        static void FindByPhoneNumber(Dictionary<string, string> phoneBook)
        {
            while (true)
            {
                Console.WriteLine("Введите номер, чтобы найти его владельца");
                string inputPhoneToFind = Console.ReadLine();
                string value;
                if (phoneBook.TryGetValue(inputPhoneToFind, out value))
                {
                    Console.WriteLine($"Номер - {inputPhoneToFind}\nВладелец - {value}");
                }
                else
                {
                    Console.WriteLine($"Номер - {inputPhoneToFind}\nВладелец - не найден");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        
        /// <summary>
        /// Пользователь добавляет номера и их владельцев, потом возвращает Dictionary
        /// </summary>
        /// <param name="phoneBook"></param>
        static Dictionary<string, string> AddPhones(Dictionary<string, string> phoneBook)
        {
            string phone;
            string fullName;
            while (true)
            {
                Console.WriteLine("Нажмите Enter, если хотите закончить добавление");
                Console.WriteLine($"Запись №{phoneBook.Count + 1}");
                Console.WriteLine("Введите номер:");
                phone = Console.ReadLine();
                if (phone == "" && phoneBook.Count > 0) break;
                else if (phone == "" && phoneBook.Count == 0)
                {
                    Console.WriteLine(" У вас 0 записей. Добавьте минимум 1 запись");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                
                Console.WriteLine("\nВведите ФИО владельца номера:");
                fullName = Console.ReadLine();
                if (fullName == "" && phoneBook.Count > 0) break;
                else if (fullName == "" && phoneBook.Count == 0)
                {
                    Console.WriteLine(" У вас 0 записей. Добавьте минимум 1 запись");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                phoneBook.Add(phone, fullName);
                Console.Clear();
            }

            if (phoneBook.Count > 1) Console.WriteLine($"Вы добавили {phoneBook.Count} номеров");
            else Console.WriteLine($"Вы добавили {phoneBook.Count} номер");

            Console.ReadKey();
            Console.Clear();
            return phoneBook;
        }

    }
}
