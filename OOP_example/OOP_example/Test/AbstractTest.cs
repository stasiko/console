using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Test
{

    abstract class AbstractTest
    {
        public void MyClass(string message)
        {
            Console.WriteLine("Parent class.");
        }

        public abstract void MyAbstractClass(string message);

        public virtual void MyVirtualClass()
        {
            Console.WriteLine("Parent virtual class");
        }
    }

    class AbstractRealisation : AbstractTest
    {

        public override void MyAbstractClass(string message)
        {
            Console.WriteLine("Child abstract class.");
        }

        public override void MyVirtualClass()
        {
            Console.WriteLine("Child virtual class.");
        }

        public new void MyClass(string message)
        {
            Console.WriteLine("Child class.");
        }
    }

}
