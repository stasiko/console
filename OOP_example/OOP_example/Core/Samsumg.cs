using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Core
{
    public class Samsumg : IMobile
    {
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

        public string Processor
        {
            get
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

        public void GetWIFIConnection()
        {
            Console.WriteLine("WIFI connected");
        }

        //This is one mwthod which shows camera functionality  
        public void CameraClick()
        {
            Console.WriteLine("Camera clicked");
        }

        //This is one overloaded method which shows camera functionality as well but with its camera's different mode(panaroma)  
        public void CameraClick(string CameraMode)
        {
            Console.WriteLine("Camera clicked in " + CameraMode + " Mode");
        }

        public void GetIEMICode()
        {
            throw new NotImplementedException();
        }

        public void Dial()
        {
            throw new NotImplementedException();
        }

        public void Receive()
        {
            throw new NotImplementedException();
        }

        public void SendMessage()
        {
            throw new NotImplementedException();
        }
    }
}
