using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace TrainingTasks
{
    /*
        Задача: Написать функцию, которая определяет, является ли одна строка перестановкой другой.
        Идея: 
            1) Определим словарь Dictionary(Key: char, Value: int) для хранения символов и то сколько раз они встречаются в строках originString и permutationString.
               Если строка имеет хотя бы один символ встречающийся нечетное кол-во раз, то строка permutationString не является перестановкой строки originString.
           *2) Реализовать алгоритм на множестве Intersect. Будет истина если все элементы из множества originString встречаются во множестве permutationString.
            3) Отсортировать символы в обеих строках и выполнить сравнение между ними.
            4) Создать словарь для каждой из строки Dictionary(Key: char, Value: int), для подсчета количества каждого символа. Дальше просто сравним результаты этих двух обьектов.
     */

    /*
      static void Main(string[] args)
        {
            string[] originString =
            {
                "bbo",
                "cat",
                "tenet",
                "abcbbbabcaacabcabcaabbbcabcabcaabbbc"
            };

            string[] permutationString =
           {
                "bob",
                "cat",
                "tenett",
                "abcabcaabbbcabcabcaabbbcabcabcaabbbc"
            };

            for (int i = 0; i < originString.Length; i++)
            {
                Console.WriteLine(Task6.DoTask6_v4(originString[i], permutationString[i]));
            }

            Console.ReadKey();
        }
     */


    class Task6
    {
        public static bool DoTask6_v1(string originString, string permutationString)
        {
            Dictionary<char, int> container = new Dictionary<char, int>();

            int i;

            if (originString.Length != permutationString.Length)
                return false;

            var watch = Stopwatch.StartNew();
            for (i = 0; i < originString.Length; i++)
            {
                if (!container.ContainsKey(originString[i]))
                {
                    container.Add(originString[i], 1);
                }
                else
                {
                    container[originString[i]]++;
                }

                if (!container.ContainsKey(permutationString[i]))
                {
                    container.Add(permutationString[i], 1);
                }
                else
                {
                    container[permutationString[i]]++;
                }
            }

            foreach (var item in container)
            {
                if ((item.Value & 1) != 0)
                {
                    watch.Stop();
                    Console.WriteLine(watch.Elapsed.TotalMilliseconds);
                    return false;
                }
            }
            watch.Stop();
            Console.WriteLine(watch.Elapsed.TotalMilliseconds);
            return true;
        }


        // Данный подход реализует алгоритм на множестве Intersect. 
        // Вернет истину если все элементы из множества originString встречаются во множестве permutationString.
        public static bool DoTask6_v2(string originString, string permutationString)
        {
            if (originString.Length != permutationString.Length)
                return false;

            List<char> set = new List<char>();
            int i;

            var watch = Stopwatch.StartNew();
            for (i = 0; i < originString.Length; i++)
            {
                set.Add(originString[i]);
            }

            for (i = 0; i < permutationString.Length; i++)
            {
                if (!set.Remove(permutationString[i]))
                {
                    set.Add(permutationString[i]);
                }
            }

            watch.Stop();
            Console.WriteLine(watch.Elapsed.TotalMilliseconds);
            return set.Count == 0;
        }

        public static bool DoTask6_v3(string originString, string permutationString)
        {
            if (originString.Length != permutationString.Length)
                return false;

            var watch = Stopwatch.StartNew();
            
            char[] origin = originString.OrderBy(x => x).ToArray();
            char[] permutation = permutationString.OrderBy(x => x).ToArray();

            for (int i = 0; i < origin.Length; i++)
            {
                if (origin[i] != permutation[i])
                {
                    watch.Stop();
                    Console.WriteLine(watch.Elapsed.TotalMilliseconds);    
                    return false;
                }
            }

            watch.Stop();
            Console.WriteLine(watch.Elapsed.TotalMilliseconds);
            return true;
        }

        public static bool DoTask6_v4(string originString, string permutationString)
        {
            if (originString.Length != permutationString.Length)
                return false;

            Dictionary<char, int> containerOrigin = new Dictionary<char, int>();
            Dictionary<char, int> containerPermutationString = new Dictionary<char, int>();

            int i;

            for (i = 0; i < originString.Length; i++)
            {
                if(!containerOrigin.ContainsKey(originString[i]))
                {
                    containerOrigin.Add(originString[i], 1);
                }
                else
                {
                    containerOrigin[originString[i]]++;
                }

                if (!containerPermutationString.ContainsKey(permutationString[i]))
                {
                    containerPermutationString.Add(permutationString[i], 1);
                }
                else
                {
                    containerPermutationString[permutationString[i]]++;
                }
            }

            foreach (var item in containerOrigin)
            {
                if(!permutationString.Contains(item.Key) && 
                    permutationString[item.Key] != item.Value)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
