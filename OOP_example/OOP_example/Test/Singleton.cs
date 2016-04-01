using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Test
{
    public sealed class Singleton
    {
        private static volatile Singleton _instance;

        //private static object syncRoot = new Object();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (_instance != null) return _instance;
                //lock (syncRoot)
                lock (typeof(Singleton))
                {
                    //if (_instance == null )
                    //{
                        _instance = new Singleton();
                    //}
                }

                return _instance;
            }
        }
    }
}
