using System;

namespace TrainingTasks
{
    /*   
        Задача: Написать функцию, ктр "сжимает" строку. Если полученная строка оказалась больше исходной, то вывести исходную.
        Например, дана строка "ZZZABBEEE", получить строку вида "Z3A1B2E3", т.е. подставить счетчик вхождения символа.   
     */

    class Task13
    {
        public static string DoTask13_v1(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
                throw new ArgumentException(nameof(inputString) + " is null or empty");

            string resultString = default;
            int count = 1;
            char c;

              for (int i = 0; i < inputString.Length; i++)
              {
                  c = inputString[i];

                  while(inputString.Length > ++i && c == inputString[i])
                  {
                      count++;
                  }

                  resultString += c;
                  resultString += count;
                  count = 1;
                  i--;
              }

          /* c = inputString[0];
            for (int i = 1; i < inputString.Length; i++)
            {
                if(c == inputString[i])
                {
                    count++;
                }
                
                if(c != inputString[i] || i == inputString.Length - 1)
                {
                    resultString += c;
                    resultString += count;
                    count = 1;
                    c = inputString[i];
                }
            }*/

            return (inputString.Length < resultString.Length) ? inputString : resultString;
        }
    }
}
