using Autofac;
using EasyConsoleCore;
using GShapesDrawer.Domain;
using GShapesDrawer.Services;

namespace GShapesDrawer.Pages
{
    abstract class ShapePage: Page
    {
        private readonly IOutputService _outputService;

        protected ShapePage(string title, GShapesDrawerProgram program) 
            : base(title, program)
        {
            _outputService = program.Container.Resolve<IOutputService>();
        }

        public override void Display()
        {
            base.Display();
            
            var shape = ReadShape();
            
            var output = ReadOutput();
            
            _outputService.Print(shape.Draw(), output);
                
            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }

        protected abstract Shape ReadShape();

        private static ShapeOutput ReadOutput()
        {
            return Input.ReadEnum<ShapeOutput>("Output");
        }
    }
}