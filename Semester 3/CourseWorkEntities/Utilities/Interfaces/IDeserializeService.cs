using System.Collections.Generic;
using CourseWorkEntities.Shapes;

namespace CourseWorkEntities.Utilities.Interfaces
{
    public interface IDeserializeService
    {
        List<Shape> DeserializeSave();

        //  List<Shape> DeserializeJson();

        //  List<Shape> DeserializeXml();
    }
}