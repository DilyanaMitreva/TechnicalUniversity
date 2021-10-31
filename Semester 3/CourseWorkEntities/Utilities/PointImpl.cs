using System;

namespace CourseWorkEntities.Utilities
{
    public class PointImpl
    {
        public Int32 X { get; set; }

        public Int32 Y { get; set; }

        public PointImpl()
        {
        }

        public PointImpl(Int32 x, Int32 y)
        {
            X = x;
            Y = y;
        }
    }
}