using System.Collections.Generic;
using CourseWorkEntities.Shapes;

namespace CourseWorkEntities.Utilities
{
    public interface ISerializeShapeService
    {
        void SerializeAsTxt(List<Shape> shapes);

        void SerializeAsJson(List<Shape> shapes);

        void SerializeAsXml(List<Shape> shapes);
    }
}