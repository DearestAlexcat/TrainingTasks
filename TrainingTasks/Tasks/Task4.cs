using System;

namespace TrainingTasks
{
    /*
        Задача: Дан отсортированный по возрастанию, но циклически сдвинутый массив. 
                Нужно вывести индекс заданного элемента X (если такой элемент есть) в массиве.
        Пример: [9, 10, 11, 1, 2, 3, 4, 5, 6, 7, 8]; X = 8
        Вывод: 10
     */

    class Task4
    {
        public static int DoTask4_v1(int x, params int[] array)
        {
            // 9, 10, 11, 1, 2, 3, 4, 5, 6, 7, 8
            int left = 0, right = array.Length - 1, middle = -1;

            while(right - left > 1)
            {
                middle = (left + right) / 2;

                if(array[middle] == x)
                {
                    return middle;
                }
            }

            return array[left] == x ? left : array[right] == x ? right : -1;
        }


       

    }
}
