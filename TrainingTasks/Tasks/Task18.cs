using System;
using System.Collections.Generic;

namespace TrainingTasks
{
    /*
        Задача: дан массив натуральных чисел. Каждое из чисел присутствует в массиве ровно два раза, 
                кроме одного. Найти число без пары.
        Идея:   использовать свойство XOR для обнуления повторяющихся элементов в массиве.
     */

    class Task18
    {
        // Обрабатывает случай если только два элемента не имеют пары
        public static void DoTask18_v0(params int[] array)
        {
            if (array == null || array.Length == 0) { throw new ArgumentNullException(nameof(array) + " is null"); }

            int result = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                result ^= array[i];
            }

            // (result & array[i]) - Это фильтр. Работает только
            // для двух элементов прошедших операцию XOR 
            // a ^ b = c --> c & b = b, c & a = a

            List<int> nums = new List<int>();

            int c;

            if (result < 0) result = -result;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) c = -array[i];
                else c = array[i];

                if ((result & c) == c && !nums.Contains(array[i]))
                {
                    nums.Add(array[i]);
                    Console.Write(array[i] + " ");
                }
            }

            Console.WriteLine();
        }

        // Обрабатывает случай если только один элемент не имеет пары
        public static void DoTask18_v1(params int[] array)
        {
            if (array == null || array.Length == 0) { throw new ArgumentNullException(nameof(array) + " is null"); }

            int result = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                result ^= array[i];
            }

            Console.WriteLine(result + " ");
        }

        public static void DoTask18_v2(params int[] array)
        {
            if (array == null || array.Length == 0) { throw new ArgumentNullException(nameof(array) + " is null"); }

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] != 0)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if(array[i] == array[j])
                        {
                            array[i] = 0;
                            array[j] = 0;
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] != 0)
                {
                    Console.Write(array[i] + " ");
                }
            }

            Console.WriteLine();
        }

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
                if(item.Value == 1)
                {
                    Console.Write(item.Key + " "); 
                }
            }

            Console.WriteLine();
        }

       

    }
}
