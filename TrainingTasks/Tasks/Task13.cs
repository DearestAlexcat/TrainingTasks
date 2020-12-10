using System;

namespace TrainingTasks
{
    /*   
        Задача: Написать функцию, ктр "сжимает" строку. Если полученная строка оказалась больше исходной, то вывести исходную.
                Например, дана строка "ZZZABBEEE", получить строку вида "Z3A1B2E3", т.е. подставить счетчик вхождения символа.   
        Идея:   Нужно просто пройти всю строку и использовать локальные счетчики для подсчета последовательности символов 
                (одного или нескольких символов). Строка после сжатия может оказаться больше первоначальной. 
                Работа со строками может оказаться дорогой, поэтому сначала узнаем размер сжатой строки, чтобы гарантировать успешность
                результата.
     */

    class Task13
    {

        static int GetCompressionStringLength(string inputString)
        {
            int count = 0, resultLength = 0;

            char c = inputString[0];
            for (int i = 1; i < inputString.Length; i++)
            {
                if (c == inputString[i])
                {
                    count++;
                }

                if (c != inputString[i] || i == inputString.Length - 1)
                {
                    resultLength += 1 + count.ToString().Length; // 1 (Исходный символ) + count (символы счетчика)
                    count = 1;
                    c = inputString[i];
                }
            }

            return resultLength;
        }

        public static string DoTask13_v1(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
                throw new ArgumentException(nameof(inputString) + " is null or empty");
            int len = GetCompressionStringLength(inputString);
            Console.WriteLine("GetCompressionStringLength " + len);
            if(inputString.Length == 1 || inputString.Length <= len)
            {
                return inputString;
            }

            string resultString = default;
            int count = 1;
            char c;

           // 1
           /*   for (int i = 0; i < inputString.Length; i++)
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
              }*/

            // 2
            c = inputString[0];
            for (int i = 1; i < inputString.Length; i++)
            {
                if(c == inputString[i])
                {
                    count++;
                }
                
                if(c != inputString[i] || i == inputString.Length - 1)
                {
                    resultString += c + count.ToString();
                    count = 1;
                    c = inputString[i];
                }
            }

            return resultString;
        }
    }
}
