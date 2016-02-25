using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Test
{
    class Structures
    {
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
