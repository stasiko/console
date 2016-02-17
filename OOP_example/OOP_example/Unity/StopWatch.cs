using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace OOP_example.Unity
{
    public class Stopwatch : HandlerAttribute
    {
        public override ICallHandler CreateHandler(Microsoft.Practices.Unity.IUnityContainer container)
        {
            return new StopwatchCallHandler();
        }
    }

    public class StopwatchCallHandler : ICallHandler
    {
        public int Order { get; set; }

        public StopwatchCallHandler() : this(0)
        {
        }

        public StopwatchCallHandler(int order)
        {
            Order = order;
        }


        public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            var result = getNext().Invoke(input, getNext);

            sw.Stop();

            Console.WriteLine();
            Console.WriteLine(String.Format("Elapsed time is {0} мс", sw.ElapsedMilliseconds));

            return result;
        }

    }
}
