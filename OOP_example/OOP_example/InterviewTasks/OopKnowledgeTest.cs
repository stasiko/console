using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.InterviewTasks
{
 public interface I
    {
        void Go();
    }
    public class A : I
    {
        public void Go()
        {
            Console.WriteLine("A.Go()");
        }
    }
    class B : A
    {
    }
    class C : B, I
    {
        public new void Go()
        {
            Console.WriteLine("C.Go()");
        }
    }
    public static class OopKnowledgeTest
    {
        public static void MainTest()
        {
            B b1 = new B();
            C c1 = new C();
            B b2 = c1;
            b1.Go();
            c1.Go();
            b2.Go();
            ((I)b2).Go();
        }
    }
}
