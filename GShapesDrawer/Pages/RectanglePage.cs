using EasyConsoleCore;
using GShapesDrawer.Domain;

namespace GShapesDrawer.Pages
{
    class RectanglePage : ShapePage
    {
        public RectanglePage(GShapesDrawerProgram program) 
            : base("Rectangle", program)
        {
        }
        
        protected override Shape ReadShape()
        {
            var width = Input.ReadInt("Please enter width:", min: 1, max: int.MaxValue);
            
            var height = Input.ReadInt("Please enter height:", min: 1, max: int.MaxValue);
            
            return new Rectangle(width, height);
        }
    }
}