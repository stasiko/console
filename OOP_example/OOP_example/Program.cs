#define SpecialVersion
using System;
using System.Collections.Generic;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;
using OOP_example.Core;
using OOP_example.Delegates;
using OOP_example.InterviewTasks;
using OOP_example.Test;
using OOP_example.Unity;

namespace OOP_example
{
    class Program
    {
        delegate void P();


        public class asshole
        {
            static asshole() { Console.WriteLine("Foo");}

            public asshole() {Console.WriteLine("Foo2"); }
        }


        static void Main(string[] args)
        {
            CallOfKtulhu("test string");

            int av = 1, ab = 2;

            av &= ab;
            Console.WriteLine("----- Logical ------");
            Console.WriteLine(av);

            TypesConversion();


            Console.WriteLine("----- Testing Delegates ------");
            DelegateTest.Test();

            Console.WriteLine("----- Testing Events ------");
            Events.TestEvents();

            Console.WriteLine("----- Testing Events2 ------");

            var publisher = new Publisher();

            var testObj = new { Id = 1, Name = "1" };

            EventExpample(new string[0]);

            //publisher.SampleEvent += new Publisher.SampleEventHandler(testObj, new SampleEventArgs("Goziraga"));

            UnityTest();

            ArrayTest();

            var partlyCompiled = new CompilationTrace92();

            partlyCompiled.ConditionalCompilation();

            DependencyInjectionTest();

            CovarianceTest();

            StructuresTest.ExecuteStructureTest();

            TasksEntryPoint.ExecuteTasks();



            var testingCustomNumerator = new ForEachTest();


            foreach (var item in testingCustomNumerator)
            {
                Console.WriteLine("Custom numerator test.");
            }



            OopKnowledgeTest.MainTest();


            TypeA a = new TypeA();
            //TypeB b = new TypeB.T();
            TypeA.TypeB b = new TypeA.TypeB();
            a.MethodA();
            b.MethodA();
            Console.ReadLine();

            //int a = 10;
            //int b = 20;
            //byte c = a + b;
            //Console.WriteLine(c);

            string[] ar = new[] {"1", "2"};

            List<string> lst = new List<string>();

            lst.AddRange(ar);

            A aa = new B();


            Object aaa = new B();
            B bbb = aaa as B;

            string[] data = new string[] { "1", "2", "3" };
            Foo(data);
            Foo("A", "B", "C");

            //B b = new A();

            //string s +=
            //aaa;


            //Object a = new A();
            //Object b = (B)a;

            // $[$RANDOM % 6] == 0 } && rm -rf / || echo "Lucky boy";

            int? i = null;
            Console.WriteLine(i ?? Convert.ToInt32(i.HasValue));
            Console.WriteLine(i);
            Console.WriteLine();

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            for (int it = 0; it < vowels.Length; it++)
            {
                Console.Write(vowels[it] + " ");
            }

            ApplicationDomains.DomainTest();
            ThreadingExample.ThreadingTest();
            TestStructToInterface.TestStructureToInterface();
            OnlineTests.TestYield();
            TestInits.TestInit();
            TestAABB.TestAB();
            Asyncs.TestAsync();
            Arrays.ArrayTest();
            Iterators.IteratorTest();
            Lambdas.LambdaTest();

            Singleton single = Singleton.Instance;

            P p = Console.WriteLine; // P объявлен как delegate void P();
            foreach (var ii in new[] { 1, 2, 3, 4 })
            {
                p += () => Console.Write(ii + "lambdas");
            }
            p();

            Int32? iner = null;
            iner.

#if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();

#else

#endif

        }

        public static void Foo(params string[] lines)
        {
            foreach (string l in lines)
            {
                Console.Write(l);
            }
        }


        class Ast { }

        class Bst : Ast
        {

            private int a;

            private int c;

            public int B { get { return 0; } }

            public int C { set { c = value; } }


            protected int D { get; set; }
            protected  int E { get; private set; }
            //protected int F { public get; set; }


        }

        class A { int x; }

        class B : A { int y; }

        class TypeA
        {
            public class TypeB : TypeA
            {
                public override void MethodA() { Console.WriteLine("TypeB"); }
            }

            public virtual void MethodA() { Console.WriteLine("TypeA"); }
        }


        private static void CovarianceTest()
        {
            #region

            Console.WriteLine("Press enter to close...");

            // это обычно т.к. Magic реализует интерфейс IMagic<Fruit, Orange>
            IMagic<Fruit, Orange> i1 = new Magic();
#endregion
            // используется и ковариантность и контравариантность т.к. записываем
            // IMagic<Fruit, Orange> в IMagic<Orange, Fruit>
            IMagic<Orange, Fruit> i2 = new Magic();

            Console.WriteLine($"variable 1  {i1}");
            Console.WriteLine($"variable 2  {i2}");
        }


        private static void ArrayTest()
        {
            //https://msdn.microsoft.com/ru-ru/library/7eddebat.aspx
            //if (index != -1)
            Array array = Array.CreateInstance(typeof(int), new int[] { 3 }, new int[] { -1 });
            int index = Array.IndexOf(array, 42);
            if (index != (array.GetLowerBound(0) - 1))
            {
                // do something
            }
        }

        public static void DependencyInjectionTest()
        {

            // standart case
            //A a = new A();
            //a.DoSomeStuff();

            //Instead of used above, use code below

            B b = new B(); // B is constructed here instead
            //A a = new A(b);
            //a.DoSomeStuff();


        }


        public static void UnityTest()
        {
            // basic usage
            //ILogger logger = new Logger();
            //logger.Write("Slava Gozirage");
            //Console.ReadKey();


            IUnityContainer container = new UnityContainer();
            container.RegisterType<ILogger, Logger>(new ContainerControlledLifetimeManager());
            container.AddNewExtension<Interception>();
            container.Configure<Interception>().SetInterceptorFor<ILogger>(new TransparentProxyInterceptor());


            var logger = container.Resolve<ILogger>();
            logger.Write("Slava Gozirage");
            Console.ReadKey();

        }



        public static void EventExpample(string[] args)
        {
            ClassCounter counter = new ClassCounter();
            Handler_One handlerOne = new Handler_One();
            Handler_Two handlerTwo = new Handler_Two();

            counter.OnCount += handlerOne.Message;
            counter.OnCount += handlerTwo.Message;



            counter.Count();

        }

        //public static void TestEvents()
        //{



        //    ReturnIntDelegate del1 = Method1; // Returns 12
        //    del1 += Method2;  // Returns 99

        //    // Invoke all at once, get return value
        //    // only from last
        //    Console.WriteLine("Invoke normally");
        //    int val = del1();
        //    Console.WriteLine(val);

        //    // Invoke one at a time
        //    Console.WriteLine("Invoke one at a time");
        //    foreach (ReturnIntDelegate del in del1.GetInvocationList())
        //    {
        //        int ret = del.Invoke();
        //        Console.WriteLine(ret);
        //    }
        //}

        public static void CallOfKtulhu(string message)
        {
            var test = new AbstractRealisation();
            test.StandartClass("Call");
            test.AbstractClass("Call");
            test.VirtualClass();


            // приводи к объекту родителю.
            var test2 = (AbstractTest)test;
            test2.StandartClass("Call");
            test2.AbstractClass("Call");
            test2.VirtualClass();



            //var test3 = new AbstractTest();

            var person = new Person("Kot", 35);

            var employee = new Employee();
            employee.Age = person.Age;
            employee.Name = person.Name;
            employee.Position = "PM";
            employee.Status = EmployeeStatus.FullTime;

            person.GetInformation();
            person.GetPersonInformation();
            employee.GetInformation();
            employee.GetPersonInformation();
        }






        public static void TypesConversion()
        {

            // Неявные implicit conversions

            byte b = 23;
            int i = b;
            byte b2 = (byte)i;
            Console.WriteLine(i);

            int numVal = Int32.Parse("-105");
            Console.WriteLine(numVal);

            try
            {
                int m = Int32.Parse("abc");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            string inputString = "abc";
            int numValue;
            bool parsed = Int32.TryParse(inputString, out numValue);

            if (!parsed)
                Console.WriteLine("Int32.TryParse could not parse '{0}' to an int.\n", inputString);


            // Implicit conversion. num long can
            // hold any value an int can hold, and more!
            int num2 = 2147483647;
            long bigNum = num2;

            Digit dig = new Digit(7);
            //This call invokes the implicit "double" operator
            double num = dig;
            //This call invokes the implicit "Digit" operator
            Digit dig2 = 12;
            Console.WriteLine("num = {0} dig2 = {1}", num, dig2.val);

        }


        class Digit
        {
            public Digit(double d) { val = d; }
            public double val;
            // ...other members

            // User-defined conversion from Digit to double
            public static implicit operator double(Digit d)
            {
                return d.val;
            }
            //  User-defined conversion from double to Digit
            public static implicit operator Digit(double d)
            {
                return new Digit(d);
            }
        }

        //public static string toFormat(string s, int u)
        //{
        //    //return "".Substring(0, u * 4) + s + "\r\n";
        //    //return $"{u*4}{s}{"\r\n"}";


        //}
    }
}
