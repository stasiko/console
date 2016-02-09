using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Test
{

    abstract class AbstractTest
    {
        public void TestNormal(string message)
        {
            Console.WriteLine("Простой класс родителя!");
        }

        public abstract void MyClassAbstract(string message);

        public virtual void ShowInfo()
        {
            Console.WriteLine("Виртуальный класс родителя!");
        }
    }

    class AbstractRealisation : AbstractTest
    {
        //public override void ShowInfo()
        //{
        //    base.ShowInfo();
        //}

        public override void MyClassAbstract(string message)
        {

            Console.WriteLine("Abstract класс наследника!");
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Виртуальный класс наследника!");
        }
    }







}
