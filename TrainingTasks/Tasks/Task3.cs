using System;

namespace TrainingTasks
{
    /*
    Задача: Напишите метод, заменяющий все пробелы в строке символами, например, '%20'.  
    Пример: 
             Ввод: "Mr John Smith "
             Вывод: "Mr%20John%20Smith%20"
    */

    class Task3
    {
        public static char[] DoTask3_v1(string str, string replacing)
        {
            // 0 Check

            if (string.IsNullOrEmpty(str)) 
                throw new ArgumentException(nameof(str) + " is null or empty");
            if (string.IsNullOrEmpty(replacing)) 
                throw new ArgumentException(nameof(replacing) + " is null or empty");

            // 1 Init

            int countSpaces = 0, i;
        
            for (i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    countSpaces++;
            }

            // (str.Length - countSpaces) + (countSpaces * replacing.Length)
            //В строке уже содержатся пробелы поэтому формулу можно упростить
            // str.Length + 2 * replacing.Length - 1 

            char[] symbols = new char[(str.Length - countSpaces) + (countSpaces * replacing.Length)];

            // 2 Solution
            
            int j, it_str = 0;
            i = 0;

            while(i < symbols.Length)
            {
                if(str[it_str] == ' ')
                {
                    for (j = 0; j < replacing.Length; j++)
                    {
                        symbols[i] = replacing[j];
                        i++;
                    }
                }
                else
                {
                    symbols[i] = str[it_str];
                    i++;
                }

                it_str++; // След. символ, Пропускаем пробел
            }
           
            return symbols;
        }
    }
}
