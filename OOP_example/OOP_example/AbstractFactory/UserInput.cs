using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.AbstractFactory
{
    class UserInput
    {

        // this method can be called with DefaultGUIFactory or SkinnedGUIFactory для получениия окна заданного вида.
        public string GetUserInput(IGUIFactory guiFactory)
        {
            // Create UI elements
            IWindow wndInput = guiFactory.CreateWindow();
            IButton btnOk = guiFactory.CreateButton();
            IButton btnCancel = guiFactory.CreateButton();
            ITextBox tbInput = guiFactory.CreateTextBox();

            //TODO: Setup the window and elements
            //wndInput.AddChild(btnOk);
            //wndInput.AddChild(btnCancel);
            //wndInput.AddChild(tbInput);

            // TODO: Show dialog
            // TODO: Get the result

            return string.Empty; //tbInput.GetText();

        }
    }
}
