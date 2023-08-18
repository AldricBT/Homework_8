using System;
using System.Collections.Generic;

namespace Homework_8
{
    class Task_1
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            FillList(20);
            PrintList();
            Console.WriteLine();
            RemoveBetween(25, 50);
            PrintList();


            void FillList(int num)
            {
                Random rnd = new Random();
                for (int i = 0; i < num; i++)
                {
                    list.Add(rnd.Next(0, 101));
                }
            }
                        
            void PrintList()
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write($"{list[i]}  ");
                }
                Console.WriteLine();
            }

            void RemoveBetween(int greaterThan, int lessThan)
            {
                if (greaterThan <= lessThan)
                {
                    list.RemoveAll(l => l > greaterThan && l < lessThan);                    
                }
                else 
                { 
                    Console.WriteLine("Введены неправильные числа!"); 
                }
            }

        }

        
    }
}
