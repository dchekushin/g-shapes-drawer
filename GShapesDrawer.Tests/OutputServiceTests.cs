using GShapesDrawer.Domain;
using GShapesDrawer.Services;
using Moq;
using NUnit.Framework;

namespace GShapesDrawer.Tests
{
    public class OutputServiceTests
    {
        private Mock<IFileOutput> _fileOutputMock;
        private Mock<IConsoleOutput> _consoleOutputMock;
        private OutputService _outputService;

        [SetUp]
        public void Setup()
        {
            _fileOutputMock = new Mock<IFileOutput>();
            _consoleOutputMock = new Mock<IConsoleOutput>();
            _outputService = new OutputService(_fileOutputMock.Object, _consoleOutputMock.Object);
        }

        [Test]
        [TestCase(ShapeOutput.Console)]
        [TestCase(ShapeOutput.File)]
        public void Print_Test(ShapeOutput output)
        {
            const string inputStr = "Test";
            _outputService.Print(inputStr, output);

            _fileOutputMock.Verify(
                m => m.Write(It.Is<string>(p => p == inputStr)),
                Times.Exactly(output == ShapeOutput.File ? 1 : 0));

            _consoleOutputMock.Verify(
                m => m.Write(It.Is<string>(p => p == inputStr)),
                Times.Exactly(output == ShapeOutput.Console ? 1 : 0));
        }
    }
}