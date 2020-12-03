using System;

namespace TrainingTasks
{
    /*
        Задача: Дан отсортированный по возрастанию, но циклически сдвинутый массив. 
                Нужно вывести индекс заданного элемента X (если такой элемент есть) в массиве.
        Пример: [9, 10, 11, 1, 2, 3, 4, 5, 6, 7, 8]; X = 8
        Вывод: 10
        Идея: Так как массив отсортирован можно поделить его на две части и определяться в какой именно находится индекс значения
     */

    // Main
    /*
        int[] m01 = new int[] { 9, 10, 11, 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] m02 = new int[] { 5, 6, 7, 1, 2, 3, 4 };
        int[] m03 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        int[] m1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };

        int[][] m = new int[7][];           
        m[0] = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        m[1] = new int[] { 2, 3, 4, 5, 6, 7, 1 };
        m[2] = new int[] { 3, 4, 5, 6, 7, 1, 2 };
        m[3] = new int[] { 4, 5, 6, 7, 1, 2, 3 };
        m[4] = new int[] { 5, 6, 7, 1, 2, 3, 4 };
        m[5] = new int[] { 6, 7, 1, 2, 3, 4, 5 };
        m[6] = new int[] { 7, 1, 2, 3, 4, 5, 6 };


        for (int j = 0; j < m01.Length; j++)
        {
            for (int i = 0; i < m01.Length; i++)
            {
                Console.Write(Task4.DoTask4_v1(i + 1, m01) + " ");
            }
            Console.WriteLine();
        }
     */

    class Task4
    {
        public static int DoTask4_v1(int x, params int[] array)
        {
            int left = 0, right = array.Length - 1, middle = -1;

            while(right - left > 1)
            {
                middle = (left + right) / 2;

                if(array[middle] == x)
                {
                    return middle;
                }

                /*
                // До упрощения. Описаны все случае когда должен срабатывать сдвиг вправо
                bool condition1 = x < array[middle] && x >= array[left] && x < array[right] && array[left] < array[middle];
                bool condition2 = x < array[middle] && x >= array[left] && x > array[right] && array[left] < array[middle];
                bool condition3 = x < array[middle] && x <= array[left] && x < array[right] && array[middle] < array[right];
                bool condition4 = x > array[middle] && x >= array[left] && x > array[right] && array[middle] < array[right];                
                */

                bool condition1234 = x < array[middle] 
                                     ?  x >= array[left] && x < array[right] || x > array[right] ||             // condition1 + condition2
                                        x <  array[left] && x < array[right] && array[middle] < array[right]    // condition3
                                     :  x > array[right] && array[middle] < array[right];                       // x > array[middle], condition4  

                if (condition1234)
                {
                    right = middle;
                }
                else
                {
                    left = middle;
                }
            }

            return array[left] == x ? left : array[right] == x ? right : -1;
        }

        public static int DoTask4_v2(int x, int left, int right, params int[] array)
        {
            // TODO: Сделать рекурсию
            return array[left] == x ? left : array[right] == x ? right : -1;
        }
    }
}
