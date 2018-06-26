using System.Windows.Forms;

namespace MovingWindow.WindowCommands
{
    internal class WindowCommandCenter : IWindowCommand
    {
        private Form currentForm;

        public WindowCommandCenter(Form currentForm)
        {
            this.currentForm = currentForm;
        }

        public bool IsCommandAvailable(Keys commandKey)
        {
            bool isCommandAvailable = false;
            if (commandKey == Keys.Enter)
            {
                isCommandAvailable = true;
            }
            return isCommandAvailable;
        }

        public void PerformCommand(Keys commandKey)
        {
            if (commandKey == Keys.Enter)
            {
                currentForm.Left = Screen.PrimaryScreen.Bounds.Width / 2 - currentForm.Width / 2;
                currentForm.Top = Screen.PrimaryScreen.Bounds.Height / 2 - currentForm.Height / 2;
            }
        }
    }
}