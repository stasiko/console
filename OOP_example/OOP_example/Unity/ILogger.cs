﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Unity
{
    interface ILogger
    {
        [Stopwatch]
        void Write(string msg);
    }
}
