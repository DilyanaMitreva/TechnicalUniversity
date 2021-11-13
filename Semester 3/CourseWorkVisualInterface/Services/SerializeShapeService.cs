using System.Collections.Generic;
using System.IO;
using System.Text;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities;

namespace CourseWorkVisualInterface.Services
{
    public class SerializeShapeService : ISerializeShapeService
    {
        public void SerializeAsTxt(List<Shape> shapes)
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

        public void SerializeAsJson(List<Shape> shapes)
        {
            throw new System.NotImplementedException();
        }

        public void SerializeAsXml(List<Shape> shapes)
        {
            throw new System.NotImplementedException();
        }
    }
}