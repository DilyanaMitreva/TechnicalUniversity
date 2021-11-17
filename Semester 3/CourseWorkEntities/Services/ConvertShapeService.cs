using System.Collections.Generic;
using System.IO;
using System.Text;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities;
using CourseWorkEntities.Utilities.Interfaces;

namespace CourseWorkEntities.Services
{
    public class ConvertShapeService : IConvertShapeService
    {
        public void ConvertToTxtFile(List<Shape> shapes)
        {
            StringBuilder sb = new StringBuilder().AppendLine("Shapes");
            foreach (Shape shape in shapes)
            {
                sb.AppendLine("<" + new string('-', 50) + ">")
                    .Append(shape.AsString())
                    .AppendLine("<" + new string('-', 50) + ">")
                    .AppendLine();
            }

            File.WriteAllText(Constant.FileLocationTxt, sb.ToString());
        }

        public void ConvertToJsonFile(List<Shape> shapes)
        {
            throw new System.NotImplementedException();
        }

        public void ConvertToXmlFile(List<Shape> shapes)
        {
            throw new System.NotImplementedException();
        }
    }
}