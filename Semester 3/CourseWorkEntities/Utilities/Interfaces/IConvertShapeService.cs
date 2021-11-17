using System.Collections.Generic;
using CourseWorkEntities.Shapes;

namespace CourseWorkEntities.Utilities.Interfaces
{
    public interface IConvertShapeService
    {
        void ConvertToTxtFile(List<Shape> shapes);

        void ConvertToJsonFile(List<Shape> shapes);

        void ConvertToXmlFile(List<Shape> shapes);
    }
}