using System.Drawing;
using CourseWorkEntities.Constants;
using CourseWorkEntities.Exceptions;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities;
using Rectangle = CourseWorkEntities.Shapes.Rectangle;

namespace CourseWorkVisualInterface.Services
{
    public static class ShapeDrawService
    {
        private static readonly Color SelectedColor = Color.Red;

        public static void DrawShape(Shape shape, Graphics graphics)
        {
            if (shape is EquilateralTriangle triangle)
            {
                DrawEquilateralTriangle(triangle, graphics);
            }
            else if (shape is Rectangle rectangle)
            {
                DrawRectangle(rectangle, graphics);
            }
            else if (shape is Circle circle)
            {
                DrawCircle(circle, graphics);
            }
            else
            {
                throw new ShapeNotSupportedException(Messages.ExceptionMessages.ShapeNotSupported);
            }
        }


        private static void DrawCircle(Circle circle, Graphics graphics)
        {
            using (Pen pen = new Pen(circle.IsSelected ? SelectedColor : circle.ColorBorder, circle.IsSelected ? 3 : 1))
            {
                graphics.DrawEllipse(pen, circle.Location.X - circle.Radius, circle.Location.Y - circle.Radius,
                    2 * circle.Radius, 2 * circle.Radius);
            }

            using (Brush brush = new SolidBrush(circle.FillColor))
            {
                graphics.FillEllipse(brush, circle.Location.X - circle.Radius, circle.Location.Y - circle.Radius,
                    2 * circle.Radius, 2 * circle.Radius);
            }
        }

        private static void DrawRectangle(Rectangle rectangle, Graphics graphics)
        {
            using (Pen pen = new Pen(rectangle.IsSelected ? SelectedColor : rectangle.ColorBorder,
                rectangle.IsSelected ? 3 : 1))
            {
                graphics.DrawRectangle(pen, rectangle.Location.X, rectangle.Location.Y, rectangle.Width,
                    rectangle.Height);
            }

            using (Brush brush = new SolidBrush(rectangle.FillColor))
            {
                graphics.FillRectangle(brush, rectangle.Location.X, rectangle.Location.Y, rectangle.Width,
                    rectangle.Height);
            }
        }

        private static void DrawEquilateralTriangle(EquilateralTriangle triangle, Graphics graphics)
        {
            Point[] points = triangle.GetVertices();
            using (Pen pen = new Pen(triangle.IsSelected ? SelectedColor : triangle.ColorBorder,
                triangle.IsSelected ? 3 : 1))
            {
                graphics.DrawPolygon(pen, points);
            }

            using (Brush brush = new SolidBrush(triangle.FillColor))
            {
                graphics.FillPolygon(brush, points);
            }
        }
        
    }
}