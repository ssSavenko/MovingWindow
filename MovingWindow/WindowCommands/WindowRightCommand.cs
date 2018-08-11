using System.Windows.Forms;

namespace MovingWindow.WindowCommands
{
    internal class WindowRightCommand : IWindowCommand
    {
        private Form currentForm;
        private int pixelsPerMove;

        public WindowRightCommand(Form currentForm, int pixelsPerMove)
        {
            this.currentForm = currentForm;
            this.pixelsPerMove = pixelsPerMove;
        }

        public bool IsCommandAvailable(Keys commandKey)
        {
            bool isCommandAvailable = false;
            if (commandKey == Keys.Right)
            {
                isCommandAvailable = true;
            }
            return isCommandAvailable;
        }

        public void PerformCommand(Keys commandKey)
        {
            if (commandKey == Keys.Right)
            {
                if (currentForm.Left + currentForm.Width + pixelsPerMove < Screen.PrimaryScreen.Bounds.Width)
                {
                    currentForm.Left = currentForm.Left + pixelsPerMove;
                }
                else
                {
                    currentForm.Left = Screen.PrimaryScreen.Bounds.Width - currentForm.Width;
                }
            }
        }
    }
}