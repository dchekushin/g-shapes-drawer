using System;

namespace GShapesDrawer.Domain
{
    public class Circle : Shape
    {
        public Circle(int radius)
        {
            Radius = radius;
        }

        private int Radius { get; }
        
        public override string Draw()
        {
            double radius = Radius;
            const double thickness = 0.3;
            const char symbol = '*';
            const char space = ' ';

            var res = string.Empty;
            var rIn = radius - thickness;
            var rOut = radius + thickness;
 
            for (var y = radius; y >= -radius; --y)
            {
                for (var x = -radius; x < rOut; x += 0.5)
                {
                    var value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        res += symbol;
                    }
                    else
                    {
                        res += space;
                    }
                }
                res += Environment.NewLine;
            }
            return res;
        }
    }
}