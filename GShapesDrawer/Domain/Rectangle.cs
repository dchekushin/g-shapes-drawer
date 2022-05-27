namespace GShapesDrawer.Domain
{
    public class Rectangle : Shape
    {
        private int Width { get; }
        private int Height { get; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string Draw()
        {
            return RectangleDrawHelper.DrawBox(Width, Height);
        }
    }
}