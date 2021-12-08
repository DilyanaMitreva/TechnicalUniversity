using System;

namespace CourseWorkEntities.Exceptions
{
    public class ShapeNotSupportedException : Exception
    {
        public ShapeNotSupportedException(string message) : base(message)
        {
        }

        public ShapeNotSupportedException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}