using System;
using System.Drawing;
using System.Text;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    [Serializable]
    public class EquilateralTriangle : Shape // равнобедрен триъгълник
    {
        public int Side { get; set; }

        private PointImpl[] _vertices;

        public EquilateralTriangle() : base()
        {
        }

        public EquilateralTriangle(int xCoordinate, int yCoordinate, int side, Color colorBorder, Color fillColor) :
            base(xCoordinate, yCoordinate, colorBorder, fillColor)
        {
            this.Side = side;
            this._vertices = GenerateVertices(side);
        }


        public override double Area => (Math.Sqrt(3) * Side * Side) / 4;

        public override bool PointInShape(PointImpl point)
        {
            double area = GetAreaByPoints(_vertices[0], _vertices[1], _vertices[2]);

            double area1 = GetAreaByPoints(point, _vertices[1], _vertices[2]);

            double area2 = GetAreaByPoints(_vertices[0], point, _vertices[2]);

            double area3 = GetAreaByPoints(_vertices[0], _vertices[1], point);

            return area == area1 + area2 + area3;
        }

        public override bool Intersect(Rectangle rectangle) // TODO
        {
            PointImpl top = _vertices[0];
            PointImpl left = _vertices[1];
            PointImpl right = _vertices[2];

            // bool result1 = PointInShape(new PointImpl(rectangle.Location.X + rectangle.Width,
            //     rectangle.Location.Y + rectangle.Height));
            //
            // bool result = (left.X <= rectangle.Location.X + rectangle.Width &&
            //                rectangle.Location.X + rectangle.Width <= right.X) &&
            //               (top.Y <= rectangle.Location.Y + rectangle.Height &&
            //                rectangle.Location.Y + rectangle.Height <= left.Y);

            return false;
        }

        public override string AsString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Equilateral Triangle")
                .Append($"Location: {this.Location.AsString()}")
                .AppendLine($"Side: {this.Side}")
                .AppendLine($"Area: {this.Area}")
                .AppendLine($"BorderColor: {this.ColorBorder.ToString()}")
                .AppendLine($"FillColor: {this.FillColor.ToString()}")
                .AppendLine($"Is Selected: {this.IsSelected.ToString()}");

            return sb.ToString();
        }

        public Point[] GetVertices()
        {
            Point[] points = new Point[3];
            this._vertices = GenerateVertices(Side);

            for (int i = 0; i < points.Length; i++)
            {
                points[i].X = this._vertices[i].X;
                points[i].Y = this._vertices[i].Y;
            }

            return points;
        }


        private PointImpl[] GenerateVertices(int side)
        {
            PointImpl[] points = new PointImpl[3];

            PointImpl middleBasePoint =
                new PointImpl(Location.X, Location.Y + (int)((Math.Sqrt(3) / 2) * side));

            points[0] = Location;

            points[1] = new PointImpl(middleBasePoint.X - side / 2, middleBasePoint.Y);

            points[2] = new PointImpl(middleBasePoint.X + side / 2, middleBasePoint.Y);


            return points;
        }

        private double GetAreaByPoints(PointImpl point1, PointImpl point2, PointImpl point3)
        {
            double result = Math.Abs((point1.X * (point2.Y - point3.Y) +
                                      point2.X * (point3.Y - point1.Y) +
                                      point3.X * (point1.Y - point2.Y)) / 2.0);

            return result;
        }
    }
}