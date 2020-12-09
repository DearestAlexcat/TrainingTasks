using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TrainingTasks
{
    /*
     Задача: Дан числовой массив. Проверить, есть ли такие два числа в массиве, перемножив которые мы получим заданное число X.
    
     */

    class Task12
    {
        public static void DoTask12_v1(int x, int[] array)
        { 
            var watch = Stopwatch.StartNew();
            int counter = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                counter++;
                for (int j = i + 1; j < array.Length; j++)
                {
                    counter++;
                    if (array[i] * array[j] == x)
                    {
                        Console.WriteLine("{0} * {1} = {2}", array[i], array[j], x);
                        
                        watch.Stop();
                        Console.WriteLine(watch.Elapsed.TotalMilliseconds + " " + watch.Elapsed.Ticks);

                        Console.WriteLine(counter);
                        return;
                    }
                }
            }
         
            Console.WriteLine("Нет результата");
            Console.WriteLine("- " + counter);
        }

        public static void DoTask12_v2(int x, int[] array)
        {
            var watch = Stopwatch.StartNew();
            int counter = 0;

            List<int> nums = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                counter++;
                if (x % array[i] == 0 && !nums.Contains(array[i]))
                {
                    nums.Add(array[i]);
                }
            }

            for (int i = 0; i < nums.Count - 1; i++)
            {
                counter++;
                for (int j = i + 1; j < nums.Count; j++)
                {
                    counter++;
                    if (nums[i] * nums[j] == x)
                    {
                        Console.WriteLine("{0} * {1} = {2}", nums[i], nums[j], x);
                       
                        watch.Stop();
                        Console.WriteLine(watch.Elapsed.TotalMilliseconds + " " + watch.Elapsed.Ticks);

                        Console.WriteLine(counter);
                        return;
                    }
                }
            }
           
            Console.WriteLine("Нет результата");
            Console.WriteLine("- " + counter);
        }

        public static void DoTask12_v3(int x, int[] array)
        {
            var watch = Stopwatch.StartNew();

            List<int> nums = new List<int>();
            Array.Sort(array);

            int i, j;

            for (i = 0; i < array.Length; i++)
            {
                if (x % array[i] == 0 && !nums.Contains(array[i]))
                {
                    nums.Add(array[i]);

                    if (nums.BinarySearch(x / array[i]) > 0)
                    {
                        Console.WriteLine("{0} * {1} = {2}", array[i], x / array[i], x);

                        watch.Stop();
                        Console.WriteLine(watch.Elapsed.TotalMilliseconds + " " + watch.Elapsed.Ticks);
                        return;
                    }
                }
            }

            Console.WriteLine("Нет результата");
        }


    }
}
