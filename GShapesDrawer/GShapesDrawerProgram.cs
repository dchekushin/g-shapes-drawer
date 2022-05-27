using Autofac;
using EasyConsoleCore;
using GShapesDrawer.Pages;

namespace GShapesDrawer
{
    public class GShapesDrawerProgram: Program
    {
        public IContainer Container { get; }
        
        public GShapesDrawerProgram(IContainer container) 
            : base("Geometric shapes drawer", true)
        {
            Container = container;
            
            AddPage(new MainPage(this));
            AddPage(new CirclePage(this));
            AddPage(new SquarePage(this));
            AddPage(new RectanglePage(this));
            AddPage(new TrianglePage(this));

            SetPage<MainPage>();
        }
    }
}