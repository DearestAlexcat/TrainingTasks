using System;

namespace TrainingTasks
{

    // Task 2. Найти минимальный элемент в отсортированном по возрастанию и циклически сдвинутом массиве
    //         Пример, [3, 4, 5, 6, 7, 8, 1, 2]
    //         Написать алгоритм, который оптимально находит минимальный элемент в таком массиве.
    /* Идея:
               Так  как массив отсортирован, можно поделить массив пополам и сравнивать крайние точки двух подмассивов.
               Когда будет найден подмассив с 2мя элементами, находим минимальный среди них.
    */

    class Task2
    {
        public static int DoTask2_v1(params int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException(nameof(array) + " is null or empty");

            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if(min > array[i])
                {
                    min = array[i];
                }
            }

            return min;
        }

        public static int DoTask2_v2(params int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException(nameof(array) + " is null or empty");
            
            int left = 0,
            right = array.Length - 1,
            middle;

            // Если элемент всего один
            // Если всего два возвращаем первый если меньше, иначе сработает проверка в конце

            // Если минимальный элемент где-то слева, то middle должен быть больше left. 
            // Если элемент слева, а условие не выполняется, значит элемент занимает одно из первых двух мест.

            if (array.Length == 1 || array[left] < array[right])
            {
                return array[left];
            }

            while (right - left > 1)
            {
                middle = (left + right) / 2; // при желании результат можно окуглить

                // go to left
                if (array[middle] < array[left])
                {
                    right = middle;
                }

                // go to right
                else if (array[middle] > array[right])
                {
                    left = middle;
                }
            }

            return array[left] < array[right] ? array[left] : array[right];
        }
    }
}
