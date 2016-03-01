using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.InterviewTasks
{
    public static class FirstNonRepeatableSymbolFromString
    {
        //На входе есть строка, "ababbacbafb"
        //на выходе нужно получить первое не повторяющийся символ
        //Привести возможные примеры, используя и не использую LINQ


        public static string GetFirstNonRepeatedChar(string str)
        {
            foreach (char c in str)
            {
                if ((str.LastIndexOf(c) - str.IndexOf(c)) == 0)
                    return c.ToString();
            }
            return "none";
        }

        public static string GetFirstNonRepeatedChar2(string str)
        {
            var dictionary = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (dictionary.ContainsKey(c))
                {
                    dictionary[c] = dictionary[c] + 1;
                }
                else
                {
                    dictionary.Add(c, 1);
                }
            }

            foreach (var d in dictionary)
            {
                if (d.Value == 1)
                {
                    return d.Key.ToString();
                }
            }

            return "none";
        }
    }

    public static class FizzBuzzWithNumbers
    {
        //Write a program that prints the numbers from 1 to 100.
        //But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz".
        //For numbers which are multiples of both three and five print "FizzBuzz".

        public static void DoFizzBuzz()
        {

            Console.WriteLine("-----------------------------");
            Console.WriteLine("FizzBuzz starting");

            for (int i = 1; i < 101; i++)
            {

                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;

                if (fizz)//(i % 3 == 0)
                    Console.WriteLine($"{i} is Fizz");

                if (buzz)// (i % 5 == 0)
                    Console.WriteLine($"{i} is Buzz");

                if (fizz && buzz)//(i % 5 == 0 && i % 3 ==0)
                    Console.WriteLine($"{i} is FizzBuzz");

            }
            Console.WriteLine("-----------------------------");
        }

        public static void DoFizzBuzz2()
        {
            for(int i = 1; i < 101; i++) Console.WriteLine("{0:#;}{1:;;Fizz}{2:;;Buzz}", i % 3 * i % 5 == 0 ? 0 : i, i % 3, i % 5);
        }

        public static void DoFizzBuzz3()
        {
            Enumerable.Range(1, 100).Select(
                n =>
                    (n%15 == 0)
                        ? "FizzBuzz"
                        : (n%3 == 0)
                            ? "Fizz"
                            : (n%5 == 0)
                                ? "Buzz"
                                : n.ToString())
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
