using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Test
{
    class NetDataTypes
    {

        static void ValueTypes(string[] args)
        {
            int a = 1;
            int b = 2;
            b = a;
            a = 3;
            Console.WriteLine(a);// 3
            Console.WriteLine(b);//1
        }

        class Test
        {
            public int x;
        }

        static void ReferenceTypes(string[] args)
        {
            Test a = new Test();
            Test b = new Test();
            a.x = 1;
            b.x = 2;
            b = a;// reference set
            b.x = 3;
            Console.WriteLine(a.x);// 3
            Console.WriteLine(b.x);// 3
        }


        // using ref and out





    }
}
