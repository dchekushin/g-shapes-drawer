using GShapesDrawer.Domain;

namespace GShapesDrawer.Services
{
    public interface IOutputService
    {
        void Print(string str, ShapeOutput output);
    }
}