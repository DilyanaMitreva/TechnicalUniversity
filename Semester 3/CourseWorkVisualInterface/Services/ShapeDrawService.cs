using System;
using System.Drawing;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities;
using Rectangle = CourseWorkEntities.Shapes.Rectangle;

namespace CourseWorkVisualInterface.Services
{
    public static class ShapeDrawService
    {
        private static readonly Color _selectedColor = Color.Red;

        public static Graphics Graphics;

        public static void DrawShape(Shape shape)
        {
            if (shape is EquilateralTriangle triangle)
            {
                DrawEquilateralTriangle(triangle);
            }
            else if (shape is Rectangle rectangle)
            {
                DrawRectangle(rectangle);
            }
            else if (shape is Circle circle)
            {
                DrawCircle(circle);
            }
        }


        private static void DrawCircle(Circle circle)
        {
            using (Pen pen = new Pen(circle.Selected ? _selectedColor : circle.ColorBorder))
            {
                Graphics.DrawEllipse(pen, circle.Location.X, circle.Location.Y, 2 * circle.Radius, 2 * circle.Radius);
            }

            using (Brush brush = new SolidBrush(circle.FillColor))
            {
                Graphics.FillEllipse(brush, circle.Location.X, circle.Location.Y, 2 * circle.Radius,
                    2 * circle.Radius);
            }
        }

        private static void DrawRectangle(Rectangle rectangle)
        {
            using (Pen pen = new Pen(rectangle.Selected ? _selectedColor : rectangle.ColorBorder))
            {
                Graphics.DrawRectangle(pen, rectangle.Location.X, rectangle.Location.Y, rectangle.Width,
                    rectangle.Height);
            }

            using (Brush brush = new SolidBrush(rectangle.FillColor))
            {
                Graphics.FillRectangle(brush, rectangle.Location.X, rectangle.Location.Y, rectangle.Width,
                    rectangle.Height);
            }
        }

        private static void DrawEquilateralTriangle(EquilateralTriangle triangle)
        {
            Point[] points = new Point[3];

            points[0].X = triangle.Location.X;
            points[0].Y = triangle.Location.Y;

            Point middlePoint =
                new Point(triangle.Location.X, triangle.Location.Y + (int)((Math.Sqrt(3) / 2) * triangle.Side));

            points[1].X = middlePoint.X - triangle.Side / 2;
            points[1].Y = middlePoint.Y;

            points[2].X = middlePoint.X + triangle.Side / 2;
            points[2].Y = middlePoint.Y;


            using (Pen pen = new Pen(triangle.Selected ? _selectedColor : triangle.ColorBorder))
            {
                Graphics.DrawPolygon(pen, points);
            }

            using (Brush brush = new SolidBrush(triangle.FillColor))
            {
                Graphics.FillPolygon(brush, points);
            }
        }
    }
}