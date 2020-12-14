using System;
using System.Collections.Generic;

namespace TrainingTasks
{
    
    class Program
    {
        static void Main(string[] args)
        {

           //int[] arr = new int[] { 1, 3, 2, 8, 3, 1, 2, 4, 4, 5, 9, 9 };
            int[] arr = new int[] { 0, 4, -1, 7, -1, 4, 9, 0 }; // 7 9

            Task18.DoTask18_v0(arr);
            Task18.DoTask18_v1(arr);
            Task18.DoTask18_v2(arr);
            Task18.DoTask18_v3(arr);

            Console.ReadKey();
        }
    }
}

