using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingWindow.WindowCommands
{
    internal class WindowUpCommand : IWindowCommand
    {
        private Form currentForm;
        private int pixelsPerMove;

        public WindowUpCommand(Form currentForm, int pixelsPerMove)
        {
            this.currentForm = currentForm;
            this.pixelsPerMove = pixelsPerMove;
        }

        public bool IsCommandAvailable(KeyEventArgs commandKey)
        {
            bool isCommandAvailable = false;
            if (commandKey.KeyData == Keys.Up)
            {
                isCommandAvailable = true;
            }
            return isCommandAvailable;
        }

        public void PerformCommand(KeyEventArgs commandKey)
        {
            if (commandKey.KeyData == Keys.Up)
            {
                if (currentForm.Top + currentForm.Height - pixelsPerMove > Screen.PrimaryScreen.Bounds.Height)
                {
                    currentForm.Top = currentForm.Top - pixelsPerMove;
                }
                else
                {
                    currentForm.Top = 0;
                }
            }
        }
    }
}
