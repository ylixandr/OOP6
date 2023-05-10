using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListNumbers
{
    class Program
    {
        // Метод для вывода списка чисел на консоль
        public static void PrintListNumbers(List<int> listInt)
        {
            Console.WriteLine("\nСписок целых чисел:");
            for (int i = 0; i < listInt.Count; i++)
                Console.Write(listInt[i].ToString() + " ");
            Console.WriteLine();
        }

        public static void ToNegative(List<int> intList2)
        {
            Console.Write("\n\nМетод на задание 2.5");
            for (int i = 0; i < intList2.Count; i++)
            {
                if (i % 2 == 0)
                {
                    intList2[i] = intList2[i] * -1;
                }
            }

            PrintListNumbers(intList2);
        }

        static void Main(string[] args)
        {
            // Создаем список целых чисел с тремя начальными элементами
            List<int> intList = new List<int>() { 1, -2, -33 };


            // Добавляем еще числа в список
            int a = 7;
            intList.Add(a);     //добавление числа в конец списока (метод Add)
            intList.Add(45);

            // еще добавляем число
            a = -12345;
            intList.Add(a);
            Console.WriteLine("\n\nПечать 1");
            PrintListNumbers(intList);

            intList.Insert(0, 22);  // Вставка числа 22 в позицию  с индексом 0 (метод Insert)
            Console.WriteLine("\n\nПечать 2");
            PrintListNumbers(intList);      // Печать списка

            intList[2] = 7654;      // Замена числа в позиции с индексом 2
            Console.WriteLine("\n\nПечать 3");
            PrintListNumbers(intList);

            intList.RemoveAt(1);    // Удаление числа из позиции с индексом 1 (Метод RemoveAt )
            Console.WriteLine("\n\nПечать 4");
            PrintListNumbers(intList);

            intList.Sort();     // Сортировка списка по возрастанию
            Console.WriteLine("\n\nПечать 5");
            PrintListNumbers(intList);

            // Часть 1 
            List<int> intList2 = new List<int>() { 1, 2, 3, 4, 5, 1003 }; //2.2
            intList2.Add(102);
            int b = 13;
            intList2.Add(b); //2.3
            PrintListNumbers(intList2);
            intList2.RemoveAt(intList2.Count - 2); //2.4
            PrintListNumbers(intList2);
            //2.5
            ToNegative(intList2);
            //2.6
            intList2.Sort();
            PrintListNumbers(intList2);
            //2.7
            intList2.Reverse();
            PrintListNumbers(intList2);
        }

    }
}