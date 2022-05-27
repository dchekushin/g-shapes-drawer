using System;

namespace GShapesDrawer.Domain
{
    public class Triangle : Shape
    {
        private int Side { get; }

        public Triangle(int side)
        {
            Side = side;
        }

        public override string Draw()
        {
            const char symbol = '*';
            const char space = ' ';
            var res = string.Empty;
            
            for (var i = 1; i <= Side; i++)
            {
                for (var j = 1; j <= ((2 * Side) - 1); j++)
                {
                    if (i != Side)
                    {
                        if (i + j < Side + 1)
                        {
                            res += space;
                        }
                        else if (i + j == Side + 1)
                        {
                            res += symbol;
                        }
                        else if (i + j > Side + 1)
                        {
                            if (j - i < Side - 1)
                            {
                                res += space;
                            }
                            else if (j - i == Side - 1)
                            {
                                res += symbol;
                            }
                        }
                    }
                    else
                    {
                        if (j % 2 != 0)
                        {
                            res += $"{symbol} ";
                        }
                    }
                }
                res += Environment.NewLine;
            }

            return res;
        }
    }
}