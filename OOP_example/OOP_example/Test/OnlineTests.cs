using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecondConsoleApp.Test2;

namespace OOP_example.Test
{
    class Base { }
    class Derived : Base { }

    public static class OnlineTests
    {


        delegate Base BaseDelegate();
        static Base GetBase() { return new Base(); }
        static Derived GetDerived() { return new Derived(); }

        public static void TestDelegates()
        {
            BaseDelegate dlgB = new BaseDelegate(GetBase);
            Base b = dlgB();

            BaseDelegate dlgD = new BaseDelegate(GetDerived);
            Derived d = dlgD() as Derived;
            //Derived d = dlgD();
        }

        static IEnumerable<string> Get()
        {
            yield return "Hello";
            Console.WriteLine("Goziraga");
            yield return "World";
        }

        public static void TestYield()
        {
            foreach (string s in Get())
            {
                Console.WriteLine(s);
                Console.WriteLine("C#");
            }
        }
    }

    public class Lion : Kitty
    {
        protected override void MakeSomeNoise()
        {
            Console.WriteLine("LOL!");
        }
    }


    interface IAdd
    {
        void Add();
    }
    struct Test : IAdd
    {
        public int n;
        public Test(int n)
        {
            this.n = n;
        }
        public void Add()
        {
            n++;
        }
    }

    public static class TestStructToInterface
    {
        public static void TestStructureToInterface()
        {
            Test t = new Test(3);
            t.Add();
            Console.WriteLine(t.n);

            IAdd iadd = t;
            iadd.Add();
            Console.WriteLine(t.n);

            //var a = new AAAAA();
            //a.get_S();
        }
    }


    class AAAAA
    {
        private string s;

        public string S
        {
            get { return s; }
            set { s = value; }
        }
        //public void get_S()
        //{
        //    SSSS = "5";
        //    s = "4";

        //    //...тело метода
        //}
        public void set_S()
        {

            //SSSS = "45";
            // ...тело метода
        }
    }

    internal class A
    {
        private int i = initA();

        public static int initA()
        {
            return 2;
        }

        public A()
        {
            print();
        }

        public virtual void print()
        {
            Console.Write(i + " ");
        }
    }
    internal class B : A
    {
        private int i = initB();

        public static int initB()
        {
            return 8;
        }

        public override void print()
        {
            Console.Write(i + " ");
        }
    }
    public static class TestInits
    {
        public static void TestInit()
        {
            A a = new B();
            a.print();
        }
    }

}
