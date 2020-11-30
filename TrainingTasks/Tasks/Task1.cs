using System;
using System.Collections.Generic;

namespace TrainingTasks
{
    // Task1: Все ли символы в строке встречаются один раз.
    // Идея: Создадим список, который будет хранить пройденные символы. 
    //       Если на очередной итерации символ встречается вновь, сразу возвращаем false.
    class Task1
    {
        public static bool DoTask1_v1(string @string)
        {
            if (string.IsNullOrEmpty(@string))
                throw new ArgumentException(nameof(@string) + " is null or empty");

            List<char> symbol = new List<char>();

            for (int i = 0; i < @string.Length; i++)
            {
                if(symbol.Contains(@string[i]))
                {
                    return false;
                }

                symbol.Add(@string[i]);
            }

            return true;
        }
    }
}
