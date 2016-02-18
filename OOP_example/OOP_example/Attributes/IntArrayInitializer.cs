using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_example.Attributes
{



public class IntArrayInitializer
{
        //[MyAttribute{ Count = 3 }]
        [MyAttribute]
        public int[] GetArray()
    {
        var type = this.GetType(); // получение описания типа
        if (Attribute.IsDefined(type, typeof(MyAttribute))) // проверка на существование атрибута
        {
            var attributeValue = Attribute.GetCustomAttribute(type, typeof(MyAttribute)) as MyAttribute; // получаем значение атрибута
            return new int[attributeValue.Count]; // используем значение атрибута для формирования результата
        }
        return new int[0];
    }


    [DllImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static extern Boolean MessageBeep(UInt32 uType);
}
}
