using System;

namespace TrainingTasks
{
    /*
     Задача: Вывести слова в строке в обратном порядке. Слова разделены только пробелами.
     */
    class Task14
    {
        public static void DoTask14_v1(string @string)
        {
            if (string.IsNullOrEmpty(@string))
                throw new ArgumentException(nameof(@string) + " is null or empty");

            int left = 0, right, lastIdx;
            int len = @string.Length - 1;
            char temp;
            char[] inputStr = @string.ToCharArray();

            while (left < len)
            {
                while (left  < len && inputStr[left]  == ' ') left++;  right = left + 1;
                while (right < len && inputStr[right] != ' ') right++; lastIdx = right--;

                if (lastIdx == len) right = lastIdx;

                while (left < right)
                {
                    temp = @string[left];
                    inputStr[left] = inputStr[right];
                    inputStr[right] = temp;
                    left++;
                    right--;
                }

                left = lastIdx;
            }

            for (int i = 0; i < inputStr.Length; i++)
            {
                Console.Write(inputStr[i]);
            }
        }
    }
}
