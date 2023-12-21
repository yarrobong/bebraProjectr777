using System;
using System.Collections.Generic;

namespace bebraProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] existingArray = { -2, -4, 0, 1, 2, 3, 4, 5, 9, 55 };
            List<int> numbersList = new List<int>();

            //  положительные элементы
            foreach (int element in existingArray)
            {
                if (element % 2 == 0)
                    numbersList.Add(element);
            }

            //  отрицательные элементы
            foreach (int element in existingArray)
            {
                if (element % 2 == 1)
                    numbersList.Add(element);
            }

            // Выводим все элементы 
            foreach (int number in numbersList)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
