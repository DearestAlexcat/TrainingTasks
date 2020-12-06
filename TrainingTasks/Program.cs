using System;
using System.Collections.Generic;

namespace TrainingTasks
{
    
    class Program
    {
        static void Main(string[] args)
        {

            // Добавить нули

            int[] a1 = new int[] { 1, 3, -8, 3, -1, 2, 1 };
            int[] a2 = new int[] { -1, 10, -9, 5, 6, -10 };
            int[] a3 = new int[] { 1, 5, 7, -20, 3, 100, -250, 88, 33, 1, -40, 120 };
            int[] a4 = new int[] { -1, 12, -6, -5 };    // 11
            int[] a5 = new int[] { -1, 12, 1, 1 };      // 14

            List<int[]> arrays = new List<int[]>();
            arrays.Add(a1);
            arrays.Add(a2);
            arrays.Add(a3);
            arrays.Add(a4);
            arrays.Add(a5);

            for (int i = 0; i < arrays.Count; i++)
            {
                Task8.DoTask8_v1(arrays[i]);
            }
         
            Console.ReadKey();
        }
    }
}
