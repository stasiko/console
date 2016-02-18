using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Attributes
{
    public class MyAttribute : Attribute // создаём собственный атрибут наследуясь от стандартного класса
    {
        public int Count { get; set; } = 3; // создаём своё свойство которое будет содержать атрибут
        // можно описать несколько свойств но для примера создаётся только одно
    }
}
