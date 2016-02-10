using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Test
{
    class BoxingUnboxing
    {

        static void TestBoxing()
        {
            int val = 5;
            object obj = val;
            int valUnboxed = (int) val;//
        }

        static void TextBoxing2()
        {
            //Преобразование типа значений в ссылку на реализуемый им интерфейс
            IComparable<int> iComp = 1;

            //Преобразование типа enum в ссылку на System.Enum
            Enum format = UriFormat.Unescaped;

            // Преобразование типа значений к типу dynamic
            dynamic d = 1;

        }

        static void TextBoxing3()
        {
            int i = 67;                              // i is a value type
            object o = i;                            // i is boxed
            System.Console.WriteLine(i.ToString());  // i is boxed

            //Распаковка применяется для классов, предназначенных для работы с объектами: например, использование ArrayList для хранения целых чисел.
            //Для хранения целых чисел в ArrayList используется упаковка. При извлечении целого числа должна быть применена распаковка.

            System.Collections.ArrayList list = new System.Collections.ArrayList();  // list is a reference type
            int n = 67;                              // n is a value type
            list.Add(n);                             // n is boxed
            n = (int)list[0];                        // list[0] is unboxed


        }

        static void TextBoxingNullables()
        {

            bool? b = false;
            int? i = 44;
            object bBoxed = b; // bBoxed contains a boxed bool.
            object iBoxed = i; // iBoxed contains a boxed int.

        }

        static void TextBoxingNullables2()
        {
            double? d = 44.4;
            object iBoxed = d;
            // Access IConvertible interface implemented by double.
            IConvertible ic = (IConvertible)iBoxed;
            int i = ic.ToInt32(null);
            string str = ic.ToString();
        }

        int AddTen(int number)  // parameter is passed by value
        {
            return number + 10;
        }

        void AddTen(ref int number)  // parameter is passed by reference
        {
            number += 10;
        }

        //Ключевое слово out имеет сходство с ключевым словом ref, но оно указывает компилятору,
        //что метод должен присвоить значение параметру, иначе возникнет ошибка компиляции.

        void SetToTen(out int number)
        {
            // If this line is not present, the code will not compile.
            number = 10;
        }

    }


    // Все типы в теории наследуются от типа System.Object, но нужно проверить от чего наследуется интерфейс ниже ?
    public interface IFoo { }
}
