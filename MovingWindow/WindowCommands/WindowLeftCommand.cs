using System.Windows.Forms;

namespace MovingWindow.WindowCommands
{
    internal class WindowLeftCommand : IWindowCommand
    {
        private Form currentForm;
        private int pixelsPerMove;

        public WindowLeftCommand(Form currentForm, int pixelsPerMove)
        {
            this.currentForm = currentForm;
            this.pixelsPerMove = pixelsPerMove;
        }

        public bool IsCommandAvailable(Keys commandKey)
        {
            bool isCommandAvailable = false;
            if (commandKey == Keys.Left)
            {
                isCommandAvailable = true;
            }
            return isCommandAvailable;
        }

        public void PerformCommand(Keys commandKey)
        {
            if (commandKey == Keys.Left)
            {
                if (currentForm.Left - pixelsPerMove > 0)
                {
                    currentForm.Left = currentForm.Left - pixelsPerMove;
                }
                else
                {
                    currentForm.Left = 0;
                }
            }
        }
    }
}
