using System;
using System.Collections.Generic;

namespace TrainingTasks
{
    /*
        Задача: Вывести первый уникальный символ в строке.
        Идея: - Для каждого символа установить счетчик, и первый попавшийся у корого значение равно 1 и будет 
              первым уникальным. 
              - Вместо счетчика можно исп. bool. При первом добавлении символа он true (единственный), при попытке 
              повторного добавления устанавливаем false (дубликат).
     */

    /*
     
        static void Main(string[] args)
        {
            Task11.DoTask11_v1("11_22_333_4_5_4_6_7");
            Console.ReadKey();
        }
     
     */

    class Task11
    {
        public static void DoTask11_v1(string @string)
        {
            if (string.IsNullOrEmpty(@string))
                throw new ArgumentException(nameof(@string) + " is null or empty");

            Dictionary<char, bool> @char = new Dictionary<char, bool>();

            int i;

            for (i = 0; i < @string.Length; i++)
            {
                if(!@char.ContainsKey(@string[i]))
                {
                    @char.Add(@string[i], true);
                }
                else
                {
                    @char[@string[i]] = false;
                }
            }

            foreach (KeyValuePair<char, bool> item in @char)
            {
                if(item.Value)
                {
                    Console.WriteLine("Первый уникальный символ в строке: " + item.Key);
                    return;
                }
            }

            Console.WriteLine("Не найден ни один уникальный символ");
        }
    }
}
