using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public bool IsCommandAvailable(KeyEventArgs commandKey)
        {
            bool isCommandAvailable = false;
            if(commandKey.KeyData == Keys.Down)
            {
                isCommandAvailable = true;
            }
            return isCommandAvailable;
        }

        public void PerformCommand(KeyEventArgs commandKey)
        {
            if (commandKey.KeyData == Keys.Down)
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
