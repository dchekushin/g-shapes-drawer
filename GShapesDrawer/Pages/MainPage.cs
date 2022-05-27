using EasyConsoleCore;

namespace GShapesDrawer.Pages
{
    class MainPage : MenuPage
    {
        public MainPage(Program program)
            : base("Shapes", program,
                new Option("Circle", () => program.NavigateTo<CirclePage>()),
                new Option("Square", () => program.NavigateTo<SquarePage>()),
                new Option("Rectangle", () => program.NavigateTo<RectanglePage>()),
                new Option("Triangle", () => program.NavigateTo<TrianglePage>()))
        {
        }
    }
}