using System;
using GShapesDrawer.Domain;

namespace GShapesDrawer.Services
{
    public class OutputService : IOutputService
    {
        private readonly IFileOutput _fileOutput;
        private readonly IConsoleOutput _consoleOutput;

        public OutputService(
            IFileOutput fileOutput,
            IConsoleOutput consoleOutput)
        {
            _fileOutput = fileOutput;
            _consoleOutput = consoleOutput;
        }

        public void Print(string str, ShapeOutput output)
        {
            if (output == ShapeOutput.Console)
            {
                _consoleOutput.Write(str);
            }
            else if (output == ShapeOutput.File)
            {
                _fileOutput.Write(str);
            }
            else
            {
                throw new NotImplementedException($"Not supported output type: '{nameof(output)}'");
            }
        }
    }
}