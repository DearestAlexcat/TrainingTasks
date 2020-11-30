using System;
using System.Collections.Generic;

namespace TrainingTasks
{
    /*    
        Есть последовательность из нулей и единиц. Необходимо вернуть максимальную длину 
        подпоследовательности, в которой количество нулей и единиц одинаково.
        Пример:
        На вход подаётся последовательность:
        • [0, 0, 1, 0, 1, 1, 1, 0, 0, 0]
        Максимальная длина подпоследовательности - 8, так как количество нулей и единиц равно 4. 
        Это последоватлеьность с 0-го индекса по 8-й.
     */

    class MaxLengthOfSubsequence
    {
        /*
            Мы фактически создаём массив, который хранит разницу кол-ва нулей и единиц, начиная с начала массива
            Например, для:
            [0, 0, 1, 0, 1, 1, 1, 0, 0, 0] получим:
            [1, 2, 1, 2, 1, 0, -1, 0, 1, 2].
            Далее задача сводится к тому, чтобы найти одинаковые числа в получившемся массиве на как можно 
            большем расстоянии друг от друга. В реализации же мы массив этот не создаём, а сворачиваем всё до хеш-таблицы, 
            попутно проверяя расстояния и записывая максимальное в Max.
        */

        public static void GetMaxLengthOfSubsequence(params int[] arr)
        {
            if(arr != null || arr.Length == 0)
            {
                if(arr.Length == 0)
                {
                    arr = new int[] { 1, 0, 1, 0 };
                }
            }

            Dictionary<int, int> hash = new Dictionary<int, int>();

            hash.Add(0, -1);

            int max = 0, k = 0, temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                k += arr[i] == 0 ? 1 : -1;

                if (!hash.ContainsKey(k))
                    hash.Add(k, i);

                if (hash.ContainsKey(k))
                    temp = i - hash[k];

                if (temp > max)
                    max = temp;
            }

            Console.Write("Your sequence:");
            // Print
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }

            Console.WriteLine("\nMaximum length of a subsequence: " + max);
            Console.ReadKey();
        }
    }
}
