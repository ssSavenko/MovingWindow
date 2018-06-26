using System.Windows.Forms;

namespace MovingWindow.WindowCommands
{
    internal interface IWindowCommand
    {
        bool IsCommandAvailable(Keys commandKey);
        void PerformCommand(Keys commandKey);
    }
}