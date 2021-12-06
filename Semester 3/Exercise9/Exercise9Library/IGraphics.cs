using System.Drawing;

namespace Exercise9Library
{
    public interface IGraphics
    {
        void DrawRectangle(Color borderColor, Color fillColor, int x, int y, int width, int height);
    }
}