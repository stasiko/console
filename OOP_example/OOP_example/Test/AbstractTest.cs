using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Test
{

    abstract class AbstractTest : IFooForAbstract
    {
        public void StandartClass(string message)
        {
            Console.WriteLine("Parent class.");
        }

        public abstract void AbstractClass(string message);

        public virtual void VirtualClass()
        {
            Console.WriteLine("Parent virtual class");
        }

        public int Id { get; set; }
    }

    public interface IFooForAbstract
    {
        int Id { get; set; }
    }

    class AbstractRealisation : AbstractTest
    {

        public double A { get; private set; }

        public override void AbstractClass(string message)
        {
            Console.WriteLine("Child abstract class.");
        }

        public override void VirtualClass()
        {
            Console.WriteLine("Child virtual class.");
        }

        public new void StandartClass(string message)
        {
            Console.WriteLine("Child class.");
        }
    }

    //abstract class AbstractTestNotUsed
    //{
    //    public void MyClass2(string message)
    //    {
    //        Console.WriteLine("Parent class.");
    //    }

    //    public abstract void MyAbstractClass2(string message);

    //    public virtual void MyVirtualClass2()
    //    {
    //        Console.WriteLine("Parent virtual class");
    //    }
    //}

}
