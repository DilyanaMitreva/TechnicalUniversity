using System.Drawing;
using CourseWorkEntities.Shapes;
using Rectangle = System.Drawing.Rectangle;

namespace CourseWorkEntities.Utilities
{
    public interface ICreateService
    { 
        Shape CreateRectangle(int xPosition, int yPosition, double height, double lenght, Color outlineColor, Color fillColor);

        Shape CreateCircle(int xPosition, int yPosition, double radius, Color outlineColor, Color fillColor);

        Shape CreateTriangle(int xPosition, int yPosition, double side, Color outlineColor, Color fillColor);

        void DrawRectangle(Rectangle rectangle);

        void DrawCircle(Circle circle);

        void DrawTriangle(Triangle triangle);
    }
}