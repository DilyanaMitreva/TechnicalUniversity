﻿using System.Drawing;
using CourseWorkEntities.Shapes;
using Rectangle = CourseWorkEntities.Shapes.Rectangle;

namespace CourseWorkVisualInterface.Services
{
    public static class ShapeDrawService
    {
        private static readonly Color SelectedColor = Color.Red;

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
            using (Pen pen = new Pen(circle.IsSelected ? SelectedColor : circle.ColorBorder, circle.IsSelected ? 3 : 1))
            {
                Graphics.DrawEllipse(pen, circle.Center.X - circle.Radius, circle.Center.Y - circle.Radius,
                    circle.Radius * 2, circle.Radius * 2);
                //Graphics.DrawEllipse(pen, circle.Location.X, circle.Location.Y, 2 * circle.Radius, 2 * circle.Radius);
            }

            using (Brush brush = new SolidBrush(circle.FillColor))
            {
                Graphics.FillEllipse(brush, circle.Center.X - circle.Radius, circle.Center.Y - circle.Radius,
                    circle.Radius * 2, circle.Radius * 2);

                // Graphics.FillEllipse(brush, circle.Location.X, circle.Location.Y, 2 * circle.Radius,
                //     2 * circle.Radius);
            }
        }

        private static void DrawRectangle(Rectangle rectangle)
        {
            using (Pen pen = new Pen(rectangle.IsSelected ? SelectedColor : rectangle.ColorBorder,
                rectangle.IsSelected ? 3 : 1))
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
            Point[] points = triangle.GetVertices();
            
            using (Pen pen = new Pen(triangle.IsSelected ? SelectedColor : triangle.ColorBorder,
                triangle.IsSelected ? 3 : 1))
            {
                Graphics.DrawPolygon(pen, points);
            }

            using (Brush brush = new SolidBrush(triangle.FillColor))
            {
                Graphics.FillPolygon(brush, points);
            }
        }

        // public void DrawTriangle(EquilateralTriangle triangle)
        // {
        //     float angle = 0;
        //
        //     PointF[] points = new PointF[3];
        //
        //     points[0].X = triangle.Location.X;
        //     points[0].Y = triangle.Location.Y;
        //
        //     points[1].X = (float)(triangle.Location.X + triangle.Side * Math.Cos(angle));
        //     points[1].Y = (float)(triangle.Location.Y + triangle.Side * Math.Sin(angle));
        //
        //     points[2].X = (float)(triangle.Location.X + triangle.Side * Math.Cos(angle - Math.PI / 3));
        //     points[2].Y = (float)(triangle.Location.Y + triangle.Side * Math.Sin(angle - Math.PI / 3));
        // }
    }
}