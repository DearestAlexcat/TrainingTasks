using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTasks
{
    /*
        Задача: Дана строка, слова в ней указаны через пробел. Вывести слова в порядке убывания длины.
        Пример: "My favorite music band is Rammstein",
        Вывод: 1. Rammstein 2. favorite 3. music 4. band 5. My 6. is
        Идея: Разбиваем строку на подстроки и сортируем по длинне.
    */

    /*
        Main

        static void Main(string[] args)
        {
            Task7.DoTask7_v3("My favorite music band is Rammstein");
            Console.ReadKey();
        }
     */

    class Task7
    {

        public static void DoTask7_v1(string inputString)
        {
            var watch = Stopwatch.StartNew();
            // 1 C# print string array in one line
            inputString.Split(new char[] { ' ' }).OrderByDescending(x => x.Length).ToList().ForEach((x) => Console.Write(x + ' '));
            watch.Stop();
            Console.WriteLine(watch.Elapsed.TotalMilliseconds);
            Console.WriteLine();

            string[] result = inputString.Split(new char[] { ' ' }).OrderByDescending(x => x.Length).ToArray();

            // 2
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // 3
            Array.ForEach(result, (x) => Console.Write(x + ' '));
            Console.WriteLine();

            // 4
            Console.Write("{0}", string.Join(" ", result));
        }

        public static void DoTask7_v2(string inputString)
        {
            int start = 0, end = 0, i, j, count;

            List<KeyValuePair<int, int>> sorted = new List<KeyValuePair<int, int>>();

            var watch = Stopwatch.StartNew();

            for (i = 0; i < inputString.Length; i++)
            {
                if(inputString[i] != ' ')
                {
                    start = i; // Индекс первого символа подстроки
                    count = 0;
                    i++;

                    while (i < inputString.Length && inputString[i] != ' ')
                    {
                        count++;
                        i++;
                    }

                    end = i - start; // Длинна подстроки
                    sorted.Add(new KeyValuePair<int, int>(start, end));
                }
            }

            // Сортировка вставкой по длинне подстроки
            /*  for (j = sorted.Count - 1; j >= 0; j--)
            {
                KeyValuePair<int, int> temp = sorted[j];

                for (int k = j - 1; k >= 0 && temp.Value > sorted[k].Value; k--)
                {
                    // Сдвиг вправо
                    sorted[k + 1] = sorted[k];
                }

                sorted[k + 1] = temp;
            }*/

            sorted.Sort(delegate (KeyValuePair<int, int> x, KeyValuePair<int, int> y)
            {
                return y.Value.CompareTo(x.Value);
            });

            
            for (i = 0; i < sorted.Count; i++)
                 Console.Write(inputString.Substring(sorted[i].Key, sorted[i].Value) + " ");


            // Медленно
            /*for (i = 0; i < sorted.Count; i++)
            {
                start = sorted[i].Key;
                end = sorted[i].Key + sorted[i].Value;

                for (j = start; j < end; j++)
                {
                    Console.Write(inputString[j]);
                }
                Console.Write(" ");
            }*/



            watch.Stop();
            Console.WriteLine(watch.Elapsed.TotalMilliseconds);
        }

        public static void DoTask7_v3(string inputString)
        {
            List<string> words = new List<string>();

            string word = "";
            var watch = Stopwatch.StartNew();

            // Кастомный сплит
            for (int i = 0; i < inputString.Length; i++)
            {
                if(inputString[i] != ' ')
                {
                    word += inputString[i];
                }
                
                // Условие необходимо чтобы добавить последнее слово
                if(inputString[i] == ' ' || i == inputString.Length - 1)
                {
                    words.Add(word);
                    word = "";
                }
            }

            words.Sort(delegate (string x, string y)
            {
                return y.Length - x.Length;
            });

            words.ForEach((x) => Console.Write(x + ' ')); 
            watch.Stop();

            Console.WriteLine(watch.Elapsed.TotalMilliseconds);
        }

    }
}
