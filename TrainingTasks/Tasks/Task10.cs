using System;
using System.Collections.Generic;

namespace TrainingTasks
{
    /*
        Задача: Если элемент матрицы равен 0, то всю строку и весь столбец нужно обнулить.
        Идея: При первом объоде регистрируем индексы строк и столбцов где встречаем нули.
                При втором проходе обнуляем элементы, которые расположены на обнуляемой строке или столбце.
     */

    /*
        static void Main(string[] args)
        {

            int[,] m = new int[3, 3]
            {
                { 0, 1, 1},
                { 1, 0, 1},
                { 1, 1, 1}
            };

            Task10.DoTask10_v1(m);

            Console.ReadKey();
        }
    */

    class Task10
    {
        // С учетом добавленных (родных) нулей

        public static bool Check(int x, int y, int width, int height)
        {
            return (x >= 0 && x < width) && (y >= 0 && y < height);
        }

        public static void ZeroRowColumn(int[,] m, int x, int y, int dx, int dy, int w, int h)
        {
            // top
            if (Check(x + dx, y + dy, w, h))
            {
                m[x + dx, y + dy] = 0;
                ZeroRowColumn(m, x + dx, y + dy, dx, dy, w, h);
            }
        }

        public static void Print(int[,] m)
        {
            int width = m.GetLength(0);
            int height = m.GetLength(1);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Console.Write(m[x, y]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void DoTask10_v1(int[,] m)
        {

            Print(m);

            int width = m.GetLength(0);
            int height = m.GetLength(1);

            int x, y;

            for (x = 0; x < width; x++)
            {
                for (y = 0; y < height; y++)
                {
                    if(m[x, y] == 0)
                    {
                       m[x, y] = 0;

                       ZeroRowColumn(m, x, y, 0, -1, width, height); // top
                       ZeroRowColumn(m, x, y, 1, 0,  width, height); // right
                       ZeroRowColumn(m, x, y, -1, 0, width, height); // left
                       ZeroRowColumn(m, x, y, 0, 1,  width, height); // bottom
                    }
                }
            }

            Print(m);
        }



        // Без учета добавленных  (родных) нулей

        public static void DoTask10_v2(int[,] m)
        {
            Print(m);

            int i, j;
            int width = m.GetLength(0);
            int height = m.GetLength(1);
            
            bool[] row = new bool[width];
            bool[] column = new bool[height];

            for (i = 0; i < width; i++)
                for (j = 0; j < height; j++)
                    if (m[i, j] == 0)
                    {
                        if (!row[i])    row[i] = true;
                        if (!column[j]) column[j] = true;
                    }

            for (i = 0; i < width; i++)
            {
                for (j = 0; j < height; j++)
                {
                    if (row[i] || column[j])
                    {
                        m[i, j] = 0;
                    }
                }
            }

            Print(m);
        }

        public static void DoTask10_v3(int[,] m)
        {
            Print(m);

            List<int> row = new List<int>();        
            List<int> column = new List<int>();     

            int i, j;
            int width = m.GetLength(0);
            int height = m.GetLength(1);

            for (i = 0; i < width; i++)
                for (j = 0; j < height; j++)
                    if(m[i, j] == 0)
                    {
                        if(!row.Contains(i))     row.Add(i);
                        if (!column.Contains(j)) column.Add(j);
                    }

            for (i = 0; i < width; i++)
            {
                for (j = 0; j < height; j++)
                {
                    if(row.Contains(i) || column.Contains(j))
                    {
                        m[i, j] = 0;
                    }
                }
            }

            Print(m);
        }

    }
}
