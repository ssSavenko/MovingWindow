using System;
using System.Windows.Forms;

namespace MovingWindow
{
    internal partial class MovingWindow : Form
    {
        private FormCommands formCommands;
        private Keys lastCommand;
        private const int pixelPerMove = 6;

        public MovingWindow()
        {
            InitializeComponent();
            formCommands = new FormCommands(this, pixelPerMove);
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            formCommands.PerformCommand(lastCommand);
        }

        private void Form_KeyDown (object sender, KeyEventArgs e)
        {
            if(formCommands.IsCommandAvailable(e.KeyData))
            {
                lastCommand = e.KeyData;
            }
        }
    }
}