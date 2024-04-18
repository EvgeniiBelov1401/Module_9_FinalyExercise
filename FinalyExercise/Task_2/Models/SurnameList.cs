using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Models
{
    internal class SurnameList
    {
        public List<string> Surnames {private get; set; }

       

        public void NotSortedList()
        {
            Surnames = new List<string>()
                {
                "Жуков",
                "Василевский",
                "Конев",
                "Рокоcсовский",
                "Малиновский"
            };
            Console.WriteLine("\tСписок фамилий:");
            foreach (string surname in Surnames)
            {
                Console.WriteLine($"\t\t{surname}");
            }
            Console.WriteLine();
        }
        public List<string> ShowList()
        {
            return Surnames;
        }
        public void Sort1(List<string> list)
        {
            list.Sort();
            Console.WriteLine("Сортировка А-Я:");
            foreach (string item in list)
            {
                Console.WriteLine($"\t{item}");
            }
        }
        public void Sort2(List<string> list)
        {
            list.Sort();
            list.Reverse();
            Console.WriteLine("Сортировка Я-А:");
            foreach (string item in list)
            {
                Console.WriteLine($"\t{item}");
            }
        }
    }
}
