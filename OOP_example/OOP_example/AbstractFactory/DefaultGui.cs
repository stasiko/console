using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.AbstractFactory
{

    public class DefaultWindow : IWindow { }
    public class DefaultButton : IButton { }
    public class DefaultTextBox : ITextBox { }

    public class DefaultGUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new DefaultButton();
        }

        public ITextBox CreateTextBox()
        {
            return new DefaultTextBox();
        }

        public IWindow CreateWindow()
        {
            return new DefaultWindow();
        }
    }

    public class SkinnedWindow : IWindow { }

    public class SkinnedButton : IButton { }

    public class SkinnedTextBox : ITextBox { }

    public class SkinnedGUIFactory : IGUIFactory
    {
        public IWindow CreateWindow()
        {
            return new SkinnedWindow();
        }

        public IButton CreateButton()
        {
            return new SkinnedButton();
        }

        public ITextBox CreateTextBox()
        {
            return new SkinnedTextBox();
        }
    }

}
