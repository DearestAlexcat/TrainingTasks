using System;
using System.Collections.Generic;

namespace TrainingTasks
{
    /*
       Задача: дан массив натуральных чисел. Каждое из чисел присутствует в массиве ровно два раза, 
               кроме одного. Найти число без пары.
       Идея:   использовать свойство XOR для обнуления повторяющихся элементов в массиве.
               В некоторых реализациях может потребоваться использование побитового И для поиска битов для обнуления.

           Можно разобрать несколько случаев для реализации
               1) В массиве не имеет пары только 1 элемент
               3) не имеют пары n элементов
    */

    class Task18
    {
        /// <summary>
        /// Случай когда 1 или 2 элемента не имееют пары
        /// </summary>
        public static void DoTask18_v0(params int[] array)
        {
            if (array == null || array.Length == 0) { throw new ArgumentNullException(nameof(array) + " is null"); }

            int first = 0, second = 0;
            int result = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                result ^= array[i];
            }

            int temp;

            for (int i = 0; i < array.Length; i++)
            {
                temp = result ^ array[i];

                if ((first ^ array[i]) != result || (temp & first) != temp || result == 0)
                {
                    first ^= array[i];
                }
                else
                {
                    second ^= array[i];
                }          
            }

            Console.WriteLine(first + " " + second);
        }

        /// <summary>
        /// Случай для n элементов, через сортировку
        /// </summary>
        public static void DoTask18_v1(params int[] array)
        {
            Array.Sort(array);

            int num = array[0]; 

            for (int i = 1; i < array.Length; i++)
            {
                if (num != array[i])
                {
                    Console.Write(num + " ");
                }
                else
                {
                    i++;
                }

                if(i < array.Length)
                { 
                    num = array[i];
                }

                if (i == array.Length - 1)
                {
                    Console.Write(num + " ");
                }
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Случай для 1-го элемента
        /// </summary>
        public static void DoTask18_v2(params int[] array)
        {
            if (array == null || array.Length == 0) { throw new ArgumentNullException(nameof(array) + " is null"); }

            int result = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                result ^= array[i];
            }

            Console.WriteLine(result + " ");
        }

        /// <summary>
        /// Случай для n элементов, через словарь
        /// </summary>
        public static void DoTask18_v3(params int[] array)
        {
            if (array == null || array.Length == 0) { throw new ArgumentNullException(nameof(array) + " is null"); }

            Dictionary<int, int> numbs = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if(numbs.ContainsKey(array[i]))
                {
                    numbs[array[i]]++;
                }
                else
                {
                    numbs.Add(array[i], 1);
                }
            }

            foreach (var item in numbs)
            {
                if((item.Value & 1) != 0)
                {
                    Console.Write(item.Key + " "); 
                }
            }

            Console.WriteLine();
        }
    }
}
