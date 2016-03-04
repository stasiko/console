using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Test
{
    public static class Asyncs
    {
        private static async Task DelayAsync()
        {
            await Task.Delay(1000);
        }
        public static void TestAsync()
        {
            var delayTask = DelayAsync();
            delayTask.Wait();
        }

    }

}
