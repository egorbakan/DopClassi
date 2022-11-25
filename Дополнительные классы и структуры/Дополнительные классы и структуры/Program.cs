using System;
using System.Collections;

namespace Дополнительные_классы_и_структуры
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {10, 1, 9, 8, 3, 4, 6, 5, 2, 7};

            Array.Sort(arr); // по возрастанию

            foreach (int memb in arr)

                Console.Write("{0} ", memb);

            Console.WriteLine();

            Array.Sort(arr, drop); // по убыванию

            foreach (int memb in arr)

                Console.Write("{0} ", memb);

            Console.WriteLine();

            
            int[] second = { 6, 7 };

            int[] result = new int[arr.Length + second.Length];
            Array.Copy(arr, result, arr.Length);
            Array.Copy(second, 0, result, arr.Length, second.Length);

            Console.WriteLine(String.Join(" ", result));

            int n;
            int b = 123;
            Console.WriteLine("Введите любое целое число ");
            n = Convert.ToInt32(Console.ReadLine());
            int res = Math.Abs(n - b);
            Console.WriteLine("Ответ = "+res);
            if(n > b)
            {
                int res2 = (n - b) * 3;
                Console.WriteLine("Ответ = " + res2);
            }
        }

        static int drop(int x, int y) // по убыванию

        {
            if (x < y)

                return 1;

            if (x == y)

                return 0;

            return -1;
        }
    }
}
