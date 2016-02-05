using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Core
{
    class AbstractExample
    {

        class Man
        {
            public void Move(bool run)
            {
                if (run)
                {
                    Run();
                }
                else
                {
                    Walk();
                }
            }
            private void Walk()
            {
                Console.WriteLine("Man is walking.");
            }
            private void Run()
            {
                Console.WriteLine("Man is running.");
            }
        }
    }
}
