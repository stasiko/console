using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Test
{
    public static class Iterators
    {
        public static void IteratorTest()
        {
            Zoo theZoo = new Zoo();

            theZoo.AddMammal("Whale");
            theZoo.AddMammal("Rhinoceros");
            theZoo.AddBird("Penguin");
            theZoo.AddBird("Warbler");
            var ices = theZoo.GetType().GetInterfaces();

            foreach (var test in theZoo)
            {
                Console.WriteLine(test.Name + "");
            }

            foreach (var type in ices)
            {
                Console.WriteLine("interface is: " + type);
            }
        }
    }

    public class Zoo //: IEnumerable<Animal>
    {
        public IEnumerator<Animal> GetEnumerator()
        {
            return ((IEnumerable<Animal>)animals).GetEnumerator();
        }

        // Private members.
        private List<Animal> animals = new List<Animal>();

        // Public methods.
        public void AddMammal(string name)
        {
            animals.Add(new Animal {Name = name, Type = Animal.TypeEnum.Mammal});
        }

        public void AddBird(string name)
        {
            animals.Add(new Animal {Name = name, Type = Animal.TypeEnum.Bird});
        }

        //public IEnumerator GetEnumerator()
        //{
        //    foreach (Animal theAnimal in animals)
        //    {
        //        yield return theAnimal.Name;
        //    }
        //}



        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }


        //public IEnumerator GetEnumerator()
        //{
        //    foreach (Animal theAnimal in animals)
        //    {
        //        yield return theAnimal.Name;
        //    }
        //}

        // Public members.
        //public IEnumerable Mammals
        //{
        //    get { return AnimalsForType(Animal.TypeEnum.Mammal); }
        //}

        //public IEnumerable Birds
        //{
        //    get { return AnimalsForType(Animal.TypeEnum.Bird); }
        //}

        // Private methods.
        //private IEnumerable AnimalsForType(Animal.TypeEnum type)
        //{
        //    foreach (Animal theAnimal in animals)
        //    {
        //        if (theAnimal.Type == type)
        //        {
        //            yield return theAnimal.Name;
        //        }
        //    }
        //}
    }


    // Private class.
        public class Animal
    {
        public enum TypeEnum { Bird, Mammal }

        public string Name { get; set; }
        public TypeEnum Type { get; set; }
    }
}
