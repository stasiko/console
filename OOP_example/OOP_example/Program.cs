using System;
using System.CodeDom.Compiler;
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

            var firstChar2 = $"222 First non repeatable symbol from string {"ababbacbafb"} is { GetFirstNonRepeatedChar2("ababbacbafb")}.";

            Console.WriteLine(firstChar);
            Console.WriteLine(firstChar2);

            var result = "success";


            TypesConversion();


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
            foreach (char c in str)
            {

                if ((str.LastIndexOf(c) - str.IndexOf(c)) == 0)
                    return c.ToString();
            }
            return "none";
        }

        public static string GetFirstNonRepeatedChar2(string str)
        {
            var dictionary = new Dictionary<char,int>();

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


        public static void TypesConversion()
        {

            // Неявные implicit conversions

            byte b = 23;
            int i = b;
            byte b2 = (byte) i;
            Console.WriteLine(i);

            int numVal = Int32.Parse("-105");
            Console.WriteLine(numVal);

            try
            {
                int m = Int32.Parse("abc");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            string inputString = "abc";
            int numValue;
            bool parsed = Int32.TryParse(inputString, out numValue);

            if (!parsed)
                Console.WriteLine("Int32.TryParse could not parse '{0}' to an int.\n", inputString);


            // Implicit conversion. num long can
            // hold any value an int can hold, and more!
            int num2 = 2147483647;
            long bigNum = num2;

            Digit dig = new Digit(7);
            //This call invokes the implicit "double" operator
            double num = dig;
            //This call invokes the implicit "Digit" operator
            Digit dig2 = 12;
            Console.WriteLine("num = {0} dig2 = {1}", num, dig2.val);

        }


        class Digit
        {
            public Digit(double d) { val = d; }
            public double val;
            // ...other members

            // User-defined conversion from Digit to double
            public static implicit operator double(Digit d)
            {
                return d.val;
            }
            //  User-defined conversion from double to Digit
            public static implicit operator Digit(double d)
            {
                return new Digit(d);
            }
        }

    }
}
