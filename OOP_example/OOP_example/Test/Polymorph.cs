using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Test
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public virtual void GetInformation()
        {
            var message = $"Person name is {this.Name}, age is {this.Age}";

            Console.WriteLine(message);
        }

        public void GetPersonInformation()
        {
            var message = $"Person only information. Name is {this.Name}, age is {this.Age}";

            Console.WriteLine(message);
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person() { }
    }

    public enum EmployeeStatus
    {
        OnProbation,
        PartTime,
        FullTime
    }

    public class Employee : Person
    {
        public string Position { get; set; } = "Cleaner";

        public EmployeeStatus Status { get; set; } = EmployeeStatus.OnProbation;

        public override void GetInformation()
        {
            var message = $"Consolidated employee information. Name is {this.Name}, age is {this.Age}, working as {Position}, status {Status}";

            Console.WriteLine(message);
        }

    }

}
