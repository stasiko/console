using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Test
{

    interface IEquatable<T>
    {
        bool Equals(T obj);
    }

    public class Car : IEquatable<Car>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        //implementation of IEquatable<T> interface
        public bool Equals(Car car)
        {
            //if (Make == car.Make && Model == car.Model && Year == car.Year)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return Make == car.Make && Model == car.Model && Year == car.Year;
        }

        /* 
        На входе есть строка, "ababbacbafb"

        на выходе нужно получить первое не повторяющийся символ 
        
        

        ""



        */


    }
}
