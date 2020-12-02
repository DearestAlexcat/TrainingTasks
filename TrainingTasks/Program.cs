using System;
using System.Collections.Generic;

namespace TrainingTasks
{
    
    class Program
    {
        static void Main(string[] args)
        {

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


            for (int j = 0; j < m.Length; j++)
            {
                for (int i = 0; i < m[j].Length; i++)
                {
                    Console.Write(Task4.DoTask4_v1(i + 1, m[j]) + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
