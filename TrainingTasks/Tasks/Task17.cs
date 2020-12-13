using System;

namespace TrainingTasks
{
    // Задача: Поменять значения двух переменных без использования третьей.
    /*
        Main

        static void Main(string[] args)
        {
            int a = 4, b = 5;
            Task17<int>.DoTask17_v1(ref a, ref b);
            Console.WriteLine(a + " " + b);
            Console.ReadKey();
        }

     */

    class Task17<T> where T : struct
    {
        // Test

        public static T Add(object a, object b) => (T)(object)((int)a + (int)b);
        public static T Sub(object a, object b) => (T)(object)((int)a - (int)b);
        public static T Mul(object a, object b) => (T)(object)((int)a * (int)b);
        public static T Div(object a, object b) => (T)(object)((int)a / (int)b);
        public static T XOR(object a, object b) => (T)(object)((int)a ^ (int)b);

        //public static void DoTask17_v2(ref T a, ref T b, Action<T, T> operation) => operation(a, b);

        public static void DoTask17_v1(ref T a, ref T b)
        {
            // Non generic version

            //a = a - b;
            //b = b + a;
            //a = b - a;

            //a = a * b;
            //b = b / a;
            //a = b / a;

            //a = a ^ b;
            //b = b ^ a;
            //a = a ^ b;

            // Generic version

            //a = Sub(a, b);
            //b = Add(b, a);
            //a = Sub(b, a);

            //a = Mul(a, b);
            //b = Div(b, a);
            //a = Div(b, a);

            a = XOR(a, b);
            b = XOR(b, a);
            a = XOR(a, b);
        }
    }
}
