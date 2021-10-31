using System;
using System.Drawing;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        private PointImpl _centerPoint;

        public override double Area => Math.PI * Radius * Radius;

        public Circle(int xCoordinate, int yCoordinate, int radius, Color colorBorder, Color fillColor) : base(
            xCoordinate, yCoordinate, colorBorder, fillColor)
        {
            this.Radius = radius;
        }


        public override Boolean PointInShape(PointImpl point)
        {
            _centerPoint = new PointImpl(this.Location.X + this.Radius, this.Location.Y + this.Radius);

            Boolean result = (point.X - _centerPoint.X) * (point.X - _centerPoint.X) +
                             (point.Y - _centerPoint.Y) * (point.Y - _centerPoint.Y)
                             <= this.Radius * this.Radius;

            return result;
        }

        public override bool Intersect(Rectangle rectangle)
        {
            // Find the nearest point on the
            // rectangle to the center of
            // the circle
            // int Xn = Math.Max(X1,
            //     Math.Min(Xc, X2));
            // int Yn = Math.Max(Y1,
            //     Math.Min(Yc, Y2));

            int xNear = Math.Max(rectangle.Location.X,
                Math.Min(_centerPoint.X, rectangle.Location.X + rectangle.Width));
            int yNear = Math.Max(rectangle.Location.Y,
                Math.Min(_centerPoint.Y, rectangle.Location.Y + rectangle.Height));

            int distanceX = xNear - _centerPoint.X;
            int distanceY = yNear - _centerPoint.Y;

            return (distanceX * distanceX + distanceY * distanceY) <= this.Radius * this.Radius;

            // Find the distance between the
            // nearest point and the center
            // of the circle
            // Distance between 2 points,
            // (x1, y1) & (x2, y2) in
            // 2D Euclidean space is
            // ((x1-x2)**2 + (y1-y2)**2)**0.5
            // int Dx = Xn - Xc;
            // int Dy = Yn - Yc;
            // return (Dx * Dx + Dy * Dy) <= R * R;
            
        }
    }
}