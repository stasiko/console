using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.InterviewTasks
{
    public static class TasksEntryPoint
    {
        public static void ExecuteTasks()
        {
            Console.WriteLine("Tasks execution begin");

            var firstChar = $"First non repeatable symbol from string {"ababbacbafb"} is {FirstNonRepeatableSymbolFromString.GetFirstNonRepeatedChar("ababbacbafb")}.";
            var firstChar2 = $"222 First non repeatable symbol from string {"ababbacbafb"} is {FirstNonRepeatableSymbolFromString.GetFirstNonRepeatedChar2("ababbacbafb")}.";
            Console.WriteLine(firstChar);
            Console.WriteLine(firstChar2);

            FizzBuzzWithNumbers.DoFizzBuzz();
            FizzBuzzWithNumbers.DoFizzBuzz2();
        }
    }
}
