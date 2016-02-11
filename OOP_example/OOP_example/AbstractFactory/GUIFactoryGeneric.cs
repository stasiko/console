using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.AbstractFactory
{
    // using generic types is often best practice for the same classes
    public class GUIFactoryGeneric<TWindow, TButton, TTextBox> : IGUIFactory
        where TWindow : IWindow, new()
        where TButton : IButton, new()
        where TTextBox : ITextBox, new()
    {
        public IWindow CreateWindow()
        {
            return new TWindow();
        }

        public IButton CreateButton()
        {
            return new TButton();
        }

        public ITextBox CreateTextBox()
        {
            return new TTextBox();
        }
    }

    public class DefaultGUIFactoryG: GUIFactoryGeneric<DefaultWindow,DefaultButton,DefaultTextBox> { };

    public class SkinnedGUIFactoryG: GUIFactoryGeneric<SkinnedWindow, SkinnedButton, SkinnedTextBox> { };

}
