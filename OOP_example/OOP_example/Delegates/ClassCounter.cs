using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Delegates
{
    class ClassCounter
    {

        public delegate void MethodContainer();


        public event MethodContainer OnCount = () => { }; //Создание анонимной функции на основе лямбда выражения.




        //public event MethodContainer OnCount = delegate{};
        //public event Action OnCount = delegate{};
        //public event EventHandler MyEvent = delegate { };


        public void Count()
        {

            var test = OnCount.GetInvocationList();

            Handler_Two handlerThree = new Handler_Two();


            OnCount += handlerThree.Message;

            //4
            var count1 = OnCount;
            //count1();


            //var test2 = OnCount.    .GetInvocationList();

            OnCount -= handlerThree.Message;

            //var count2 = (MethodContainer)OnCount;

            //var count3 = OnCount;

            var count2 = OnCount;

            //OnCount += handlerThree.Message;

            //OnCount.GetInvocationList();
            //count3.GetInvocationList();
            //count2.GetInvocationList();



            for (int i = 0; i < 100; i++)
            {
                if (i == 71)
                {
                    OnCount.Invoke();
                }
            }


            Action a = () => Console.WriteLine("event 1");
            var b = a;
            a += () => Console.WriteLine("event 2");

            Console.WriteLine("EVENT a:");
            Console.WriteLine("---------------");
            a();
            Console.WriteLine();
            Console.WriteLine("EVENT b:");
            Console.WriteLine("---------------");
            b();
        }
    }

    class Handler_One
    {
        public void Message()
        {
            Console.WriteLine("We are reached 71!");
        }
    }

    class Handler_Two
    {
        public void Message()
        {
            Console.WriteLine("Right, ist 71 already.");
        }
    }


    /*
    А также не раскрыта разница между
public event EventHandler Changed
и
public EventHandler Changed
        */

    class Class
    {
        EventHandler сhanged;
        public event EventHandler Changed
        {
            add
            {
                сhanged += value;
            }
            remove
            {
                сhanged -= value;
            }
        }
    }


    delegate void MyEventHandler();
    class MyEvent
    {
        public event MyEventHandler SomeEvent;
        void OnSomeEvent()
        {
            if (SomeEvent != null) SomeEvent();
        }
        public void MyMethod()
        {
            int X;
            for (X = 10; X <= 20; X++)
                if (X == 15) OnSomeEvent();
        }

    }
}

