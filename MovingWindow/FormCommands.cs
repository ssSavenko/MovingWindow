using MovingWindow.WindowCommands;
using System.Windows.Forms;

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
                new WindowCommandCenter(currentForm),
                new WindowLeftCommand(currentForm, pixelPerMove),
                new WindowRightCommand(currentForm, pixelPerMove),
                new WindowUpCommand(currentForm, pixelPerMove)
            };
        }

        public bool IsCommandAvailable(Keys commandKey)
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

        public void PerformCommand(Keys commandKey)
        {
            foreach (var command in windowCommands)
            {
                command.PerformCommand(commandKey);
            }
        }
    }
}
