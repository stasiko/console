
#define TRACE_ON
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//#define SpecialVersion


namespace OOP_example.Core
{
    //namespace OOP_example.Delegates{}



    public class CompilationTrace92
    {
        public void ConditionalCompilation()
        {
            #if SpecialVersion
                 Console.WriteLine("this is special version cofiguration");
            #else
                 Console.WriteLine("this is standard version cofiguration");
            #endif
        }
    }

    public class Trace
    {
        [Conditional("TRACE_ON")]
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    //[Conditional("DEBUG")]
    //public void Test()
    //{
    //    MessageBox.Show("I want cookie");
    //}
    //ctor()
    //{
    //    this.Test();
    //    this.GetType().InvokeMember("Test", BindingFlags.InvokeMethod, null, this, null);
    //}
}
