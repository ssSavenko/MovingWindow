using System;
using System.Windows.Forms;

namespace MovingWindow
{
    internal partial class MyForm : Form
    {
        private FormCommands formCommands;
        private Keys lastCommand;
        private const int pixelPerMove = 6;

        public MyForm()
        {
            InitializeComponent();
            formCommands = new FormCommands(this, pixelPerMove);
            lastCommand = Keys.Down;
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            formCommands.PerformCommand(lastCommand);
        }

        private void MyForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(formCommands.IsCommandAvailable(e.KeyData))
            {
                lastCommand = e.KeyData;
            }
        }
    }
}
