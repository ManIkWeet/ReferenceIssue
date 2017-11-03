using MainProject;
using System;
using System.Windows;

namespace EntryPoint
{
    internal class Executable
    {
        [STAThread]
        private static void Main()
        {

            var app = new Application();
            app.Run(new MainWindow());
        }
    }
}
