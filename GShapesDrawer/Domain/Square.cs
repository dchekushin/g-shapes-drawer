namespace GShapesDrawer.Domain
{
    public class Square : Shape
    {
        private int Side { get; }

        public Square(int side)
        {
            Side = side;
        }

        public override string Draw()
        {
            return RectangleDrawHelper.DrawBox(Side, Side);
        }
    }
}