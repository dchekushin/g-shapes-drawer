using System;

namespace GShapesDrawer.Domain
{
    public static class RectangleDrawHelper
    {
        public static string DrawBox(int width, int height)
        {
            const char symbol = '*';
            const char space = ' ';
            var res = string.Empty;

            if (height > 1)
            {
                res += DrawRow(width, symbol, symbol);
            }
            
            for (var i = 1; i < height - 1; ++i)
            {
                res += DrawRow(width, symbol, space);
            }
            res += DrawRow(width, symbol, symbol);
            return res;
        }

        private static string DrawRow(int width, char symbol, char space)
        {
            var res = string.Empty;
            res += symbol;
            for (var i = 1; i < width - 1; ++i)
            {
                res += space;
            }

            if (width > 1)
            {
                res += symbol;
            }

            res += Environment.NewLine;
            return res;
        }
    }
}