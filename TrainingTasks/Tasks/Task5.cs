using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTasks
{
    class Task5
    {

        /*
            Задача: Написать функцию, ктр будет проверять можно ли преобразовать строку так, чтобы она стала палиндромом.
            Пример:
            "bob" => true - уже является палиндромом
            "bbo" => true - можно сделать палиндромом
            "cat" => false - нельзя сделать палиндромом
         */

        public static bool DoTask5_v1(string str)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
                return false;

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

            return (str.Length % 2 == 0 && counter == 0 || 
                    str.Length % 2 != 0 && counter == 1);
        }
    }
}
