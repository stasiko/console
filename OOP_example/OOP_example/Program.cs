using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OOP_example.Test;

namespace OOP_example
{
    class Program
    {
        static void Main(string[] args)
        {
            CallOfKtulhu("test string");

            var firstChar = $"First non repeatable symbol from string {"ababbacbafb"} is { GetFirstNonRepeatedChar("ababbacbafb")}.";

            Console.WriteLine(firstChar);
            var result = "success";

#if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
#endif

        }


        public static void CallOfKtulhu(string message)
        {
            var test = new AbstractRealisation();
            test.MyClass("Call");
            test.MyAbstractClass("Call");
            test.MyVirtualClass();

            var test2 = (AbstractTest)test;
            test2.MyClass("Call");
            test2.MyAbstractClass("Call");
            test2.MyVirtualClass();

            //var test3 = new AbstractTest();

            var person = new Person("Kot", 35);

            var employee = new Employee();
            employee.Age = person.Age;
            employee.Name = person.Name;
            employee.Position = "PM";
            employee.Status = EmployeeStatus.FullTime;

            person.GetInformation();
            person.GetPersonInformation();
            employee.GetInformation();
            employee.GetPersonInformation();
        }



        //На входе есть строка, "ababbacbafb"

        //    на выходе нужно получить первое не повторяющийся символ

        public static string GetFirstNonRepeatedChar(string str)
        {
            string test5 = string.Empty;

            foreach (char c in str)
            {

                //str.ToCharArray();
                var result = str.Contains(c.ToString());

                if ((str.LastIndexOf(c) - str.IndexOf(c)) == 0)
                    return test5 = c.ToString();
            }
            return test5 = "none";
        }

    }
}
