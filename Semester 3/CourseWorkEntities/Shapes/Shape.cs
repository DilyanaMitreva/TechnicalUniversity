using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    public abstract class Shape
    {
        public ShapeType ShapeType { get; set; }
        public int XCoordinate { get; set; }

        public int YCoordinate { get; set; }

        protected Shape(int xCoordinate, int yCoordinate)
        {
            this.XCoordinate = xCoordinate;
            this.YCoordinate = yCoordinate;
        }

        public abstract double GetArea();

        public abstract void Draw();
    }

   
}