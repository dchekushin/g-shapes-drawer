using EasyConsoleCore;
using GShapesDrawer.Domain;

namespace GShapesDrawer.Pages
{
    class CirclePage : ShapePage
    {
        public CirclePage(GShapesDrawerProgram program) 
            : base("Circle", program)
        {
        }

        protected override Shape ReadShape()
        {
            var radius = Input.ReadInt("Please enter radius:", min: 1, max: int.MaxValue);
            return new Circle(radius);
        }
    }
}