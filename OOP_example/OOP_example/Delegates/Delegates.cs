using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Delegates
{
    public delegate string FirstDelegate(int x);

    public class Sample
    {
        //public string Invoke(int x);
        //public System.IAsyncResult BeginInvoke(int x, System.AsyncCallback callback, object state);
        //public string EndInvoke(IAsyncResult result);

        public delegate void SecondDelegate(char a, char b);



        public static void TestDelegates()
        {
            /* Два выражения создания экземпляров делегатов d1 и d2 эквивалентны. Здесь InstanceMethod является экземплярным методом, который объявлен в классе, в котором также объявлены нижеприведённые выражения (базовый класс). Соответственно, ссылка на экземпляр объекта — this, и именно поэтому эти выражения эквивалентны. */
            //FirstDelegate d1 = new FirstDelegate(InstanceMethod);
            //FirstDelegate d2 = new FirstDelegate(this.InstanceMethod);

            /* Здесь (d3) мы создаём экземпляр делегата, ссылающийся на тот же метод, что и в предыдущих двух выражениях, но на этот раз с другим экземпляром класса. */
            //FirstDelegate d3 = new FirstDelegate(anotherInstance.InstanceMethod);

            /* В этом (d4) экземпляре делегата используется уже другой метод, тоже экземплярный, который объявлен в другом классе; мы указываем экземпляр этого класса и сам метод. */
            //FirstDelegate d4 = new FirstDelegate(instanceOfOtherClass.OtherInstanceMethod);

            /* А вот этот (d5) экземпляр делегата использует статический метод, который расположен в том же классе, где и это выражение (базовом классе). */
            // FirstDelegate d5 = new FirstDelegate(StaticMethod);

            /* Здесь (d6) экземпляр делегата использует другой статический метод, объявленный на этот раз в стороннем классе. */
            //FirstDelegate d6 = new FirstDelegate(OtherClass.OtherStaticMethod);
        }
    }

    public class DelegateTest
    {
        string name;

        static void Test()
        {
            FirstDelegate d1 = new FirstDelegate(StaticMethod);

            DelegateTest instance = new DelegateTest();
            instance.name = "My instance";
            FirstDelegate d2 = new FirstDelegate(instance.InstanceMethod);

            Console.WriteLine(d1(10));// shows Static method 10
            Console.WriteLine(d2(5));// shows My instance: 5
        }

        static string StaticMethod(int i)
        {
            return string.Format("Static method:{0}", i);
        }

         string InstanceMethod(int i)
        {
            return string.Format("{0}: {1}", name, i);
        }
    }




}
