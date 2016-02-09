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


            var test3 = GetFirstNonRepeatedChar("ababbacbafb");

            var result = "success";

        }


        public static void CallOfKtulhu(string message)
        {
            var test = new AbstractRealisation();
            test.TestNormal("Call");
            test.MyClassAbstract("Call");
            test.ShowInfo();

            var test2 = (AbstractTest) test;
            test2.ShowInfo();
            test2.TestNormal("Test of original abstract");
            test2.TestNormal("Test of original public");



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
