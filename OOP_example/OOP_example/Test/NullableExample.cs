using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Test
{
    class NullableExample
    {
        /*
        Use the ?? operator to assign a default value that will be applied when a nullable type whose current value
        is null is assigned to a non-nullable type, for example int? x = null; int y = x ?? -1;

        Nested nullable types are not allowed. The following line will not compile: Nullable<Nullable<int>> n;
    */


        static void TestNullables()
        {
            int? num = null;

            // Is the HasValue property true?
            if (num.HasValue)
            {
                System.Console.WriteLine("num =" + num.Value);
            }
            else
            {
                System.Console.WriteLine("num = Null");
            }

            //y is set to zero
            int y = num.GetValueOrDefault();

            // num.Value throws an InvalidOperationException if num.HasValue is false
            try
            {
                y = num.Value;
            }
            catch (System.InvalidCastException e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Done with exception handling.");
            }

        }



    }
}
