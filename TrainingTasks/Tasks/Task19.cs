using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTasks
{

    /*
        Задача: Дана матрица символов. Нужно проверить, входит ли заданное слово ("bird") в числовую матрицу. 
                Слово полностью находится либо в строке либо в столбце либо на любой из диагоналей.
     
     */
    class Task19
    {

        public static void DoTask17_v1(string word, char[,] m)
        {
            if (string.IsNullOrEmpty(word) || m == null) return;
            if (m.GetLength(0) > word.Length && m.GetLength(1) > word.Length ||
                m.GetLength(0) < word.Length && m.GetLength(1) < word.Length)
            {
                Console.WriteLine("Нельзя определить");
                return;
            }



        }

    }
}
