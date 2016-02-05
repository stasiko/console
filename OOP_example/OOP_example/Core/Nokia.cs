using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Core
{
    public class Nokia : IMobile
    {
        public Battery Battery
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string IEMICode
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int InternalMemory
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsSingleSIM
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Processor
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string SIMCard
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Dial()
        {
            throw new NotImplementedException();
        }

        public void GetBlueToothConnection()
        {
            Console.WriteLine("Bluetooth connected");
        }

        public void GetIEMICode()
        {
            throw new NotImplementedException();
        }

        public void Receive()
        {
            throw new NotImplementedException();
        }

        //New implementation for this method which was available in Mobile Class
        //This is runtime polymorphism
        //public override void SendMessage()
        //{
        //    Console.WriteLine("Message Sent to a group");
        //}
    }
}
