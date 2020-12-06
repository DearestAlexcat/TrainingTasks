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

    class Task8
    {
        public static void DoTask8_v1(params int[] array)
        {
            int currentSum = 0;
            int lastSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > 0)
                {
                    currentSum += array[i];

                    if(currentSum < 0)
                    {
                        currentSum = array[i];
                    }

                    lastSum = currentSum;
                }
                else if(currentSum >= 0)
                {
                    currentSum += array[i];

                    if(currentSum < 0 && i > 0)
                    {
                        currentSum = 0;
                    }
                }
            }

            Console.WriteLine(currentSum > lastSum ? currentSum : lastSum);
        }
    }
}
