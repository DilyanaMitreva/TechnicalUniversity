using System;
using System.Drawing;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    public class EquilateralTriangle : Shape // равнобедрен триъгълник
    {
        public int Side { get; set; }

        public EquilateralTriangle(int xCoordinate, int yCoordinate, int side, Color colorBorder, Color fillColor) :
            base(xCoordinate, yCoordinate, colorBorder, fillColor)
        {
            this.ShapeType = ShapeType.Triangle;
            this.Side = side;
        }

        public override decimal Area =>((decimal)Math.Sqrt(3) * Side * Side) / 4;

        public override bool PointInShape(PointImpl point)
        {
            throw new NotImplementedException();
        }

        public override bool Intersect(Shape shape)
        {
            throw new NotImplementedException();
        }

        // public override void Draw(Graphics graphics)
        // {
        //     float angle = 0;
        //
        //     PointF[] points = new PointF[3];
        //
        //     points[0].X = this.XCoordinate;
        //     points[0].Y = this.YCoordinate;
        //     
        //     points[1].X = (float)(this.XCoordinate + this.Side * Math.Cos(angle));
        //     points[1].Y = (float)(this.YCoordinate + this.Side * Math.Sin(angle));
        //     
        //     points[2].X = (float)(this.XCoordinate + this.Side * Math.Cos(angle - Math.PI / 3));
        //     points[2].Y = (float)(this.YCoordinate + this.Side * Math.Sin(angle - Math.PI / 3));
        //
        // }
    }
}