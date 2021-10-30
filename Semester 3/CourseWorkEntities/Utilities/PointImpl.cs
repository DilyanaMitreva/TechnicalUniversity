namespace CourseWorkEntities.Utilities
{
    public class PointImpl
    {
        public int X { get; set; }

        public int Y { get; set; }

        public PointImpl()
        {
        }

        public PointImpl(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}