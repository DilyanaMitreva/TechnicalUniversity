using System.Collections.Generic;
using CourseWorkEntities.Shapes;

namespace CourseWorkEntities.Utilities.Interfaces
{
    public interface IDeserializeShapeService
    {
        List<Shape> DeserializeFromJsonFile();
    }
}