using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Test
{
    class Covariance
    {
    }

    class Fruit
    {
        public void Eat()
        {
            Console.WriteLine("You ate fruit!");
        }
    }

    class Orange : Fruit { }

    interface IMagic<in TIn, out TOut>
    {
        TOut DoMagic(TIn smth);
    }

    class Magic : IMagic<Fruit, Orange>
    {
        public Orange DoMagic(Fruit smth)
        {
            return new Orange();
        }
    }

    //class Program2
    //{
    //    static void Main(string[] args)
    //    {
    //        // это обычно т.к. Magic реализует интерфейс IMagic<Fruit, Orange>
    //        IMagic<Fruit, Orange> i1 = new Magic();

    //        // используется и ковариантность и контравариантность т.к. записываем
    //        // IMagic<Fruit, Orange> в IMagic<Orange, Fruit>
    //        IMagic<Orange, Fruit> i2 = new Magic();
    //    }
    //}
}
