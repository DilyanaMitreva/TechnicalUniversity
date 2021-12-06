using System;

namespace CourseWorkEntities.Exceptions
{
    public class EmptyCollectionException : Exception
    {
        public EmptyCollectionException(string message) : base(message)
        {
        }

        public EmptyCollectionException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}