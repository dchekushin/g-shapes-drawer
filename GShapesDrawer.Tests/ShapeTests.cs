using System.Collections.Generic;
using GShapesDrawer.Domain;
using NUnit.Framework;

namespace GShapesDrawer.Tests
{
    public class ShapeTests
    {
        [Test, TestCaseSource(nameof(TestCaseData))]
        public void Shape_Test(Shape shape, string expected)
        {
            var actual  = shape.Draw();
            
            Assert.AreEqual(expected, actual);
        }

        private static IEnumerable<object[]> TestCaseData()
        {
            yield return new object[] { new Circle(1), " *** \r\n*   *\r\n *** \r\n" };
            yield return new object[] { new Square(3), "***\r\n* *\r\n***\r\n" };
            yield return new object[] { new Square(3), "***\r\n* *\r\n***\r\n" };
            yield return new object[] { new Rectangle(3, 4), "***\r\n* *\r\n* *\r\n***\r\n" };
            yield return new object[] { new Triangle(3), "  *\r\n * *\r\n* * * \r\n" };
        }
    }
}