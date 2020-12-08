using System;

namespace TrainingTasks
{
    /*
        Задача: Дан массив целых чисел. Вывести максимальную сумму элементов в массиве. 
                Суммировать элементы можно только последовательно.
        Пример: [-1, 10, -9, 5, 6, -10],
        Вывод: 12
        Пример: [1, 5, 7, -20, 3, 100, -250, 88, 33, 1, -40, 120] 
        Вывод: 202
        Пример: [1, 3, -8, 3, -1, 2, 1] 
        Вывод: 5
    */

    /*
    
    Main

     static void Main(string[] args)
        {
            int[] a1 = new int[] { 1, 3, -8, 3, -1, 2, 1 }; // 5
            int[] a2 = new int[] { -1, 10, -9, 5, 6, -10 }; // 12
            int[] a3 = new int[] { 1, 5, 7, -20, 3, 100, -250, 88, 33, 1, -40, 120 }; // 202
            int[] a4 = new int[] { -1, 12, -6, -5 };    // 11
            int[] a5 = new int[] { -1, 12, 1, 1 };      // 14
            int[] a6 = new int[] { 10, -9, 5, 6, -10, 4, 1, 2, 3 };  // 12

            List<int[]> arrays = new List<int[]>();
            arrays.Add(a1);
            arrays.Add(a2);
            arrays.Add(a3);
            arrays.Add(a4);
            arrays.Add(a5);
            arrays.Add(a6);

            for (int i = 0; i < arrays.Count; i++)
            {
                Task8.DoTask8_v1(arrays[i]);
            }
         
            Console.ReadKey();
        }


     */

    class Task8
    {
        public static void DoTask8_v1(params int[] array)
        {
            if(array == null || array.Length == 1)
            {
                Console.WriteLine("Макс. сумма равна 0");
                return;
            }

            int currentSum, lastSum, index = -1;
            currentSum = lastSum = 0;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                currentSum += array[i];

                if(currentSum > lastSum)
                {
                    count++;
                    index = i;
                    lastSum = currentSum;
                }
                if (currentSum < 0)
                {
                    currentSum = 0;
                }

               /* if (array[i] > 0)
                {
                    count++;

                    if (currentSum < 0)
                    {
                        lastSum = currentSum = array[i];
                    }
                    else if(currentSum > lastSum)
                    {
                        index = i;
                        lastSum = currentSum;
                    }
                }
                else if (currentSum < 0)
                {
                    Console.WriteLine("*");
                    currentSum = 0;
                }*/
            }

            // Если суммирование не произошло, либо все элементы отрицательны, либо только один положительный
            if(count == 1)
            {
                int left = index - 1;
                int right = index + 1;
                lastSum = 0;

                if (left < 0 && array[index] + array[right] > 0)
                {
                    currentSum = array[index] + array[right];
                }
                else if(right == array.Length && array[index] + array[left] > 0)
                {
                    currentSum = array[index] + array[left];
                }
                else
                {
                    currentSum = array[index] + (array[left] > array[right] ? array[left] : array[right]);
                 
                    if (currentSum < 0)
                    { 
                        currentSum = 0;
                    }
                }
            }

            Console.WriteLine(currentSum + " " + lastSum);
            Console.WriteLine("Макс. сумма равна {0}", currentSum > lastSum ? currentSum : lastSum);
        }
    }
}
