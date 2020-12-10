using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TrainingTasks
{
    /*
     Задача: Дан числовой массив. Проверить, есть ли такие два числа в массиве, перемножив которые мы получим заданное число X.
     Идея: Задачу можно решить в лоб поиском нужных сомножетелей. 
           Второй вариант - опеределение факта наличия нужных сомножетелей. 
     */

    class Task12
    {

        // Определяем факт начиличия сомножетелей

        public static bool DoTask12_v1(int x, int[] array)
        {
            Dictionary<int, int> items = new Dictionary<int, int>();
            int mod, div, count;

            for (int i = 0; i < array.Length; i++)
            {
                if(items.ContainsKey(array[i]))
                {
                    items[array[i]]++;
                }
                else
                {
                    items.Add(array[i], 1);
                }
            }
   
            foreach (var item in items)
            {
                div = x / item.Key;
                mod = x % item.Key;

                if(mod == 0)
                {
                    count = items.ContainsKey(div) ? items[div] : 0;

                    // x = div * div
                    // x = div * item

                    if (div == item.Key && count > 1 ||
                        div != item.Key && count > 0)
                        return true;
                }
            }

            return false;
        }

        public static bool DoTask12_v2(int x, int[] array)
        {
            List<int> items = new List<int>();
            int mod, div;

            for (int i = 0; i < array.Length; i++)
            {
                mod = x % array[i];
                if (mod == 0 && !items.Contains(array[i]))
                {
                    items.Add(array[i]);
                }
            }

            foreach (var item in items)
            {
                div = x / item;
                if(items.Contains(div))
                    return true;
            }

            return false;
        }

        public static void DoTask12_v3(int x, int[] array)
        { 
            
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
                        Console.WriteLine(counter);
                        return;
                    }
                }
            }
         
            Console.WriteLine("Нет результата");
            Console.WriteLine("- " + counter);
        }

        public static void DoTask12_v4(int x, int[] array)
        {
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
                        Console.WriteLine(counter);
                        return;
                    }
                }
            }
           
            Console.WriteLine("Нет результата");
            Console.WriteLine("- " + counter);
        }

        public static void DoTask12_v5(int x, int[] array)
        {
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
                        return;
                    }
                }
            }

            Console.WriteLine("Нет результата");
        }


    }
}
