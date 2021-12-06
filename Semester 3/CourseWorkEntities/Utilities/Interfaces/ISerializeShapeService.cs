using System.Collections.Generic;
using CourseWorkEntities.Shapes;

namespace CourseWorkEntities.Utilities.Interfaces
{
    public interface ISerializeShapeService
    {
        void SerializeToTxtFile(List<Shape> shapes);

        void SerializeToJsonFile(List<Shape> shapes);

        void SerializeToXmlFile(List<Shape> shapes);
        
        void SerializeSave(List<Shape> shapes);
    }
}