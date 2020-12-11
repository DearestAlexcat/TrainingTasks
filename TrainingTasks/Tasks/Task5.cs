using System.Collections.Generic;

namespace TrainingTasks
{
    class Task5
    {

        /*
            Задача: Написать функцию, которая будет проверять можно ли преобразовать строку так, чтобы она стала палиндромом.
            Пример:
            "bob" => true - уже является палиндромом
            "bbo" => true - можно сделать палиндромом
            "cat" => false - нельзя сделать палиндромом
            Идея: Определим словарь Dictionary(Key: char, Value: int) для хранения символов и то сколько раз они встречаются в строке.
                  Если строка имеет более одного символа, которые встречаются нечетное кол-во раз, то строка не является палиндромом.
         */

        /* Main
        static void Main(string[] args)
        {
            string[] strs =
            {
                "bbo",
                "bob",
                "cat",
                "tenet",
                "abcabcaabbbc"
            };

            for (int i = 0; i < strs.Length; i++)
            {
                Console.WriteLine(Task5.DoTask5_v2(strs[i]));
            }

            Console.ReadKey();
        }
        */

        public static bool DoTask5_v1(string str)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
                return false;

            // Строка длинной в 1 символ будет считаться палиндромом
            if (str.Length == 1)
                return true;
            
            int counter = 0;

            List<char> container = new List<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if(!container.Contains(str[i]))
                {
                    container.Add(str[i]);
                    counter++;
                }
                else
                {
                    container.Remove(str[i]);
                    counter--;
                }
            }

            return counter <= 1;
           /* return (str.Length & 1) == 0 && counter == 0 || 
                   (str.Length & 1) != 0 && counter == 1;  */
        }

        public static bool DoTask5_v2(string str)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
                return false;

            // Строка длинной в 1 символ будет считаться палиндромом
            if (str.Length == 1)
                return true;

            // Init

            Dictionary<char, int> container = new Dictionary<char, int>();

            int i, count = 0;

            for (i = 0; i < str.Length; i++)
            {
                if(!container.ContainsKey(str[i]))
                {
                    container.Add(str[i], 1);
                }
                else
                {
                    container[str[i]]++;
                }
            }

            foreach (var item in container)
            {
                if ((item.Value & 1) != 0)
                {
                    count++;
                }

                if (count > 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
