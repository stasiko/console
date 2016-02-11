using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.AbstractFactory
{

    public interface IWindow { }

    public interface  IButton { }

    public interface ITextBox { }

    public interface IGUIFactory
    {
        IWindow CreateWindow();
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
