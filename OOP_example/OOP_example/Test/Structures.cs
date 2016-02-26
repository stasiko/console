using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Test
{
    public static class StructuresTest
    {
        public static void ExecuteStructureTest()
        {
            int? m = null;

            Console.WriteLine(m.GetValueOrDefault());
            StructureTest structureTest3;
            structureTest3.A = 1;
            structureTest3.Field = "test";
            StructureTest? structureTest = new StructureTest();
            var structTest2 = (Foo)structureTest3;

            structureTest = null;
            Console.WriteLine($"Structure test  {structureTest.GetValueOrDefault().A.ToString()} {structureTest.GetValueOrDefault().Field }");


            Point p = new Point(1, 1);
            Console.WriteLine(p);
            p.Change(2, 2);
            Console.WriteLine(p);
            Object o = p;

            Console.WriteLine(o);
            ((Foo)o).Change(3, 3);
            Console.WriteLine(o);
        }
    }

    public struct StructureTest : Foo
    {
        public int A;
        //public static string Field = "432514";
        public string Field;

        //static StructureTest()
        //{
        //    Field = "test";
        //}
        public void Change(Int32 x, Int32 y)
        {
          //
        }
        public StructureTest(int a, string field)
        {
            A = a;
            Field = field;
        }
    }

    public interface Foo
    {
        void Change(Int32 x, Int32 y);
    }

    internal struct Point : Foo
    {
        private Int32 m_x, m_y;

        public Point(Int32 x, Int32 y)
        {
            m_x = x;
            m_y = y;
        }

        public void Change(Int32 x, Int32 y)
        {
            m_x = x;
            m_y = y;
        }

        public override String ToString()
        {
            return String.Format("({0}, {1})", m_x.ToString(), m_y.ToString());
        }
    }
}
