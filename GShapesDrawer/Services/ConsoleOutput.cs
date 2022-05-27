using System;

namespace GShapesDrawer.Services
{
    public class ConsoleOutput : IConsoleOutput
    {
        public void Write(string shape)
        {
            Console.Write(shape);
        }
    }
}