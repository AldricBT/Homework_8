using System;
using System.Collections.Generic;

namespace Task_3
{
    class Task_3
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int>();

            Console.WriteLine("Программа предложит вводить числа в коллекцию. " +
                "Ввод пустой строки означает выход из программы.");
            while (true)
            {
                Console.Write("Введите число: ");
                string input = Console.ReadLine();
                if (input == "") break;
                try
                {
                    int num = int.Parse(input);
                    if (numbers.Contains(num))
                    {
                        Console.WriteLine("Это число уже содержится в коллекции!");
                    }
                    else
                    {
                        numbers.Add(num);
                        Console.WriteLine("Число успешно сохранено.");
                    }                        
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }



        }
    }
}
