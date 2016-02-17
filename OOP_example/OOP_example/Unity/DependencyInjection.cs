using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Unity
{
    class DependencyInjection
    {


    }

    public class A
    {
        private B b;

        //basic approach
        //public A()
        //{
        //    this.b = new B(); // A *depends on* B
        //}

        public A(B b)
        { // A now takes its dependencies as arguments
            this.b = b; // look ma, no "new"!
        }

        public void DoSomeStuff()
        {
            // Do something with B here
        }
    }

    public class B
    {
    }
}
