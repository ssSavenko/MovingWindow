using System.Windows.Forms;

namespace MovingWindow.WindowCommands
{
    internal class WindowDownCommand : IWindowCommand
    {
        private Form currentForm;
        private int pixelPerMove;

        public WindowDownCommand(Form currentForm, int pixelPerMove)
        {
            this.currentForm = currentForm;
            this.pixelPerMove = pixelPerMove;
        }

        public bool IsCommandAvailable(Keys commandKey)
        {
            bool isCommandAvailable = false;
            if(commandKey == Keys.Down)
            {
                isCommandAvailable = true;
            }
            return isCommandAvailable;
        }

        public void PerformCommand(Keys commandKey)
        {
            if (commandKey == Keys.Down)
            {
                if (currentForm.Top + currentForm.Height + pixelPerMove < Screen.PrimaryScreen.Bounds.Height)
                {
                    currentForm.Top = currentForm.Top + pixelPerMove;
                }
                else
                {
                    currentForm.Top = Screen.PrimaryScreen.Bounds.Height - currentForm.Height;
                }
            }
        }
    }
}