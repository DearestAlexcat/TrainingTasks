using System;
using System.Collections.Generic;

namespace TrainingTasks
{
    
    class Program
    {
        static void Main(string[] args)
        {

            //  int[] arr = new int[] { 1, 3, 2, 8, 3, 1, 2, 4, 4, -5, 9, 9 };
            //  int[] arr = new int[] { 0, 4, -1, 78, -1, 4, 0, -9 }; // 7 9

            int[][] arrs = new int[][]
            {
                 new int[] { 1, -3, 2, 0, -3, 1, 2, 4, 4, 1, 9, 9 },    // 8, 5
                 new int[] { 1, -3, 2, -8, -3, 1, 2, 4, 4, -5, 9, 9 },     // 8, -5
                 new int[] { 0, -4, -1, -6, -1, -4, 0, -8 },                // 6, 8
                 new int[] { 0,- 4, -1, 5, -1, -4, 0, 8 },                // 8, 5
                 new int[] { 0, -4, -1, -78, -1, -4, 0, -9 },              // 78, -9
            };

            for (int i = 0; i < arrs.Length; i++)
            {
                Task18.DoTask18_v1(arrs[i]);
                Task18.DoTask18_v0(arrs[i]);
                Task18.DoTask18_v3(arrs[i]);
                Console.WriteLine(new string('-', 10));
            }


            
           // Console.WriteLine(new string('-', 10));
           // Task18.DoTask18_v2(arr);
           // Task18.DoTask18_v3(arr);

            Console.ReadKey();
        }
    }
}

