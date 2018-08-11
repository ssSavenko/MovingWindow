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

        public bool IsCommandAvailable(Keys commandKey)
        {
            bool isCommandAvailable = false;
            if (commandKey == Keys.Up)
            {
                isCommandAvailable = true;
            }
            return isCommandAvailable;
        }

        public void PerformCommand(Keys commandKey)
        {
            if (commandKey == Keys.Up)
            {
                if (currentForm.Top - pixelsPerMove > 0)
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