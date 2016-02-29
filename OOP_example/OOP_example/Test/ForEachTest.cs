using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Test
{
     public class ForEachTest
    {
        public Enumerator GetEnumerator()
        {
            return new Enumerator();
        }
    }

    public class Enumerator : IDisposable
    {
        public bool MoveNext()
        {
            return false;
        }

        public object Current
        {
            get { return null; }
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }
    }
}
