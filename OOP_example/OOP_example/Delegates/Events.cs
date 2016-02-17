using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Delegates
{

    public class SampleEventArgs
    {
        public SampleEventArgs(string s) { Text = s; }
        public String Text { get; private set; } // readonly
    }

    public class Publisher
    {
        public delegate void SampleEventHandler(object sender, SampleEventArgs e);

        public event SampleEventHandler SampleEvent;

        public virtual void RaiseSampleEvent()
        {
            //if (SampleEvent != null)
            //{
            //    SampleEvent(this, new SampleEventArgs("Goziraga"));
            //}

            SampleEvent?.Invoke(this, new SampleEventArgs("Goziraga"));

           // SampleEvent?.BeginInvoke(this, new SampleEventArgs("fdsf"),)
        }
    }


    public class Events
    {
        public event EventHandler MyEvent
        {
            add { Console.WriteLine("Add operation");}

            remove { Console.WriteLine("Remove operation");}
        }

        public static void TestEvents()
        {
            Events t = new Events();

            t.MyEvent += new EventHandler(t.DoNothing);
            t.MyEvent -= null;

        }

        private void DoNothing(object sender, EventArgs e)
        {
        }
    }
}
