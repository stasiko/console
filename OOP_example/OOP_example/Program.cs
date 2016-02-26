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
        static void Main(string[] args)
        {
            CallOfKtulhu("test string");




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

#if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
#endif

        }

        private static void CovarianceTest()
        {

            Console.WriteLine("Press enter to close...");

            // это обычно т.к. Magic реализует интерфейс IMagic<Fruit, Orange>
            IMagic<Fruit, Orange> i1 = new Magic();

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
            A a = new A(b);
            a.DoSomeStuff();


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
