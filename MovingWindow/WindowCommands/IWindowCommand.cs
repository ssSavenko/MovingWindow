using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingWindow.WindowCommands
{
    internal interface IWindowCommand
    {
        void PerformCommand(KeyEventArgs commandKey);
        bool IsCommandAvailable(KeyEventArgs commandKey);
    }
}