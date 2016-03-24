using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.InterviewTasks
{
    public static class TasksEntryPoint
    {
        /*
        Write a program that prints the numbers from 1 to 100. But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". For numbers which are multiples of both three and five print "FizzBuzz".
Write a loop that counts from 1 to 10" or "What's the number after F in hexadecimal?
Write recursion to solve a real problem.
standard a=a+b, b=a-b, a=a-b problem if they're integers, then I'd do it by a=a|b, b=a^b, a=a^b.
Give me a list of the text files in this directory that contain phone numbers in a specific format.
When would you use a hashtable versus an array?"
Why do programmers think asking if Oct 31 and Dec 25 are the same day is funny?
 Write a function that determines if a string starts with an upper-case letter A-Z
 Write a function that determines the area of a circle given the radius
 Add up all the values in an array
            */










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
