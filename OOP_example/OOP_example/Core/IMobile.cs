using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Core
{
    public interface IMobile
    {
        string IEMICode { get; set; }
        string SIMCard { get; set; }
        string Processor { get; }
        int InternalMemory { get; }
        bool IsSingleSIM { get; set; }

        // encapsulation - aggregation
        Battery Battery { get; set; }

        void GetIEMICode();

        void Dial();

        void Receive();
        void SendMessage();
    }
}
