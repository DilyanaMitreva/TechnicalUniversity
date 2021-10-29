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

        public override decimal GetArea()
        {
            decimal result = ((decimal)Math.Sqrt(3) * Side * Side) / 4;
            return result;
        }


        public override void Draw(Graphics graphics)
        {
            float angle = 0;

            PointF[] p = new PointF[3];

            p[0].X = this.XCoordinate;

            p[0].Y = this.YCoordinate;

            p[1].X = (float)(this.XCoordinate + this.Side * Math.Cos(angle));

            p[1].Y = (float)(this.YCoordinate + this.Side * Math.Sin(angle));

            p[2].X = (float)(this.XCoordinate + this.Side * Math.Cos(angle + Math.PI / 3));

            p[2].Y = (float)(this.YCoordinate + this.Side * Math.Sin(angle + Math.PI / 3));

            using (Pen pen = new Pen(this.ColorBorder))
            {
                graphics.DrawPolygon(pen, p);
            }
        }
    }
}