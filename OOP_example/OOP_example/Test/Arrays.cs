using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Test
{
    public static class Arrays
    {
        public static void ArrayTest()
        {

            object[] arr = new object[] { "string", 0, new Guid() };
            foreach (object var in arr)
            {
                Console.WriteLine(var.GetType().ToString());
            }
            Console.ReadKey();
            arr.GetType().GetInterfaces();
            double d = 0.0;
            ValueType[] arr2 = new ValueType[] { d, 0, new Guid() };
            foreach (ValueType var in arr2)
            {
                Console.WriteLine(var.GetType().ToString());
            }
        }

    }
}
