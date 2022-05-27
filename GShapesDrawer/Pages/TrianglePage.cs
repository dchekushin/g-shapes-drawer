using EasyConsoleCore;
using GShapesDrawer.Domain;

namespace GShapesDrawer.Pages
{
    class TrianglePage : ShapePage
    {
        public TrianglePage(GShapesDrawerProgram program) 
            : base("Triangle", program)
        {
        }

        protected override Shape ReadShape()
        {
            var side = Input.ReadInt("Please enter side:", min: 1, max: int.MaxValue);
            return new Triangle(side);
        }
    }
}