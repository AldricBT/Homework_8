using System;
using System.Collections.Generic;

namespace Task_2
{
    class Task_2
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> book = new Dictionary<string, string>();

            Console.WriteLine("Программа предложит вводить номер телефона и ФИО владельца.");
            Console.WriteLine("Ввод пустой строки означает окончание ввода.");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Введите номер телефона: ");                
                string number = Console.ReadLine();
                if (number == "")
                {
                    Console.WriteLine("Вы ввели пустую строку. Ввод номеров завершен.");
                    break;
                }
                if (book.ContainsKey(number))
                {
                    Console.WriteLine("Этот телефон уже содержится в базе!");
                }
                else 
                {
                    Console.Write("Введите ФИО владельца: ");
                    string fio = Console.ReadLine();
                    if (fio == "")
                    {
                        Console.WriteLine("Вы ввели пустую строку. Ввод номеров завершен.");
                        break;
                    }                            
                    book.Add(number, fio);
                }                
            }
            Console.WriteLine();

            Console.WriteLine("Давайте найдем владельца по введенному номеру телефона.");

            while (true)
            {
                Console.Write("Введите номер телефона для поиска в книге: ");
                string number = Console.ReadLine();
                if (number == "")
                {
                    Console.WriteLine("Вы ввели пустую строку. Поиск по книге завершен.");
                    break;
                }
                if (book.TryGetValue(number, out string fio))
                {
                    Console.WriteLine($"Владелец: {fio}.");
                }
                else
                {
                    Console.WriteLine("Такого номера нет в книге");
                }
            }
            




        }
    }
}
