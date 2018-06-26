using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingWindow
{
    internal partial class MyForm : Form
    {
        private char lastCommand;
        private FormCommands formCommands;
        private const int pixelPerMove = 6;
        public MyForm()
        {
            InitializeComponent();
            formCommands = new FormCommands(this, pixelPerMove);
            lastCommand = ' ';
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
        }

        private void MyForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (formCommands.PerformCommand(e))
            {
                lastCommand = e.KeyChar;
            }
        }
    }
}
