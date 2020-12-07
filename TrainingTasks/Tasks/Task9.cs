using System;

namespace TrainingTasks
{

    /*
     Задача: Напишите программу, которая будет печатать числа Фибоначчи максимально долго (без ошибок времени выполнения)
     Идея: Необходимо избежать переполнение типа.
     */

    class Task9
    {
        public static void DoTask9_v1(int prev, int last)
        {
            last = prev + last;
            prev = last - prev;
            Console.WriteLine(last);

            if(int.MaxValue - prev > last)
            {
                DoTask9_v1(prev, last);
            }
        }
    }
}
