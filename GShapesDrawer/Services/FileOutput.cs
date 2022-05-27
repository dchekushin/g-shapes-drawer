using System.IO;
using System.Reflection;

namespace GShapesDrawer.Services
{
    public class FileOutput: IFileOutput
    {
        public void Write(string shape)
        {
            const string fileName = "shape.txt";
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fileName);
            using (var sw = File.CreateText(path))
            {
                sw.Write(shape);
            }
        }
    }
}