using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public static class intExtensions
    {
        public static void IsNonPair(this int input)
        {

            if(input % 2 != 0)
            {
                Console.WriteLine("Число непарне");
            }
            else Console.WriteLine("Число парне");
        }
        public static void IsPair(this int input)
        {

            if (input % 2 == 0)
            {
                Console.WriteLine("Число парне");
            }
            else Console.WriteLine("Число непарне");
        }
        public static bool IsPrime(this int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        public static int CountVowels(this string input)
        {
            int count = 0;
            foreach (char c in input)
            {
                if ("AEIOUaeiou".IndexOf(c) != -1)
                {
                    count++;
                }
            }
            return count;
        }
        public static int CountConsonants(this string input)
        {
            int count = 0;
            foreach (char c in input)
            {
                if ("PFTSKBVDZGHMNRLWJpftskbvdzghmnrlwj".IndexOf(c) != -1)
                {
                    count++;
                }
            }
            return count;
        }

    }
    internal class cs1
    {
        

        public static void task_1()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть число:");
            int a = int.Parse(Console.ReadLine());

            a.IsPair();
            Console.WriteLine();

            a.IsNonPair();
            Console.WriteLine();

            if (a.IsPrime())
            {
                Console.WriteLine($"Число {a} є простим.");
            }
            else
            {
                Console.WriteLine($"Число {a} не є простим.");
            }
            Console.WriteLine();

            Console.WriteLine("Введіть рядок");
            string b = Console.ReadLine();

            Console.WriteLine($"У рядку '{b}' є {b.CountVowels()} голосних.");
            Console.WriteLine();

            Console.WriteLine($"У рядку '{b}' є {b.CountConsonants()} приголосних.");



        }
    }
}
