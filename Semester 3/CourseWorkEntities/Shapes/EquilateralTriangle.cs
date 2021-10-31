﻿using System;
using System.Drawing;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    public class EquilateralTriangle : Shape // равнобедрен триъгълник
    {
        public Int32 Side { get; set; }

        private PointImpl[] _vertices;

        public EquilateralTriangle(Int32 xCoordinate, Int32 yCoordinate, Int32 side, Color colorBorder, Color fillColor) :
            base(xCoordinate, yCoordinate, colorBorder, fillColor)
        {
            this.Side = side;
            this._vertices = GetVertices();
        }

        public override Double Area => (Math.Sqrt(3) * Side * Side) / 4;

        public override Boolean PointInShape(PointImpl point)
        {
            double area = GetAreaByPoints(_vertices[0], _vertices[1], _vertices[2]);

            double area1 = GetAreaByPoints(point, _vertices[1], _vertices[2]);

            double area2 = GetAreaByPoints(_vertices[0], point, _vertices[2]);

            double area3 = GetAreaByPoints(_vertices[0], _vertices[1], point);

            return area == area1 + area2 + area3;
        }
        
        private PointImpl[] GetVertices()
        {
            PointImpl[] points = new PointImpl[3];

            PointImpl middlePoint =
                new PointImpl(this.Location.X, this.Location.Y + (int)((Math.Sqrt(3) / 2) * this.Side));

            points[0] = new PointImpl(this.Location.X, this.Location.Y);

            points[1] = new PointImpl(middlePoint.X - this.Side / 2, middlePoint.Y);

            points[2] = new PointImpl(middlePoint.X + this.Side / 2, middlePoint.Y);


            return points;
        }

        private Double GetAreaByPoints(PointImpl point1, PointImpl point2, PointImpl point3)
        {
            double result = Math.Abs((point1.X * (point2.Y - point3.Y) +
                                      point2.X * (point3.Y - point1.Y) +
                                      point3.X * (point1.Y - point2.Y)) / 2.0);

            return result;
        }
    }
}