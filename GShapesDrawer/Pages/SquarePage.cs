using EasyConsoleCore;
using GShapesDrawer.Domain;

namespace GShapesDrawer.Pages
{
    class SquarePage : ShapePage
    {
        public SquarePage(GShapesDrawerProgram program) 
            : base("Square", program)
        {
        }
        
        protected override Shape ReadShape()
        {
            var side = Input.ReadInt("Please enter side:", min: 1, max: int.MaxValue);
            return new Square(side);
        }
    }
}