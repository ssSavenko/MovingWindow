using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovingWindow.WindowCommands;

namespace MovingWindow
{
    internal class FormCommands
    {
        private IWindowCommand[] windowCommands;

        public FormCommands(Form currentForm, int pixelPerMove)
        {
            windowCommands = new IWindowCommand[]
            {
                new WindowDownCommand(currentForm, pixelPerMove),
                new WindowLeftCommand(currentForm, pixelPerMove),
                new WindowRightCommand(currentForm, pixelPerMove),
                new WindowUpCommand(currentForm, pixelPerMove)
            };
        }

        public void PerformCommand(KeyEventArgs commandKey)
        {
            foreach (var command in windowCommands)
            {
                command.PerformCommand(commandKey);
            }
        }

        public bool IsCommandAvailable(KeyEventArgs commandKey)
        {
            bool isCommandAvailable = false;
            foreach (var command in windowCommands)
            {
                isCommandAvailable = command.IsCommandAvailable(commandKey);
                if (isCommandAvailable)
                {
                    break;
                }
            }
            return isCommandAvailable;
        }
    }
}
