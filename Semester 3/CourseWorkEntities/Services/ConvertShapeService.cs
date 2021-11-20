using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities;
using CourseWorkEntities.Utilities.Interfaces;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;


namespace CourseWorkEntities.Services
{
    public class ConvertShapeService : IConvertShapeService
    {
        public void ConvertToTxtFile(List<Shape> shapes)
        {
            string text = new StringBuilder()
                .Append($"Shapes count: {shapes.Count}" + Constant.ShapeSeparatorTxt)
                .Append(shapes.Select(s => s.AsString())
                    .Aggregate((f, s) =>
                        f + Constant.ShapeSeparatorTxt + s))
                .AppendLine(Constant.ShapeSeparatorTxt)
                .ToString();


            File.WriteAllText(Constant.FileLocationTxt, text);

            // StringBuilder sb = new StringBuilder().AppendLine("Shapes");
            // foreach (Shape shape in shapes)
            // {
            //     sb.AppendLine(Constant.ShapeSeparatorTxt)
            //         .Append(shape.AsString())
            //         .AppendLine(Constant.ShapeSeparatorTxt);
            // }
            //
            // File.WriteAllText(Constant.FileLocationTxt, sb.ToString());
        }

        public void ConvertToJsonFile(List<Shape> shapes)
        {
            string json = JsonConvert.SerializeObject(shapes, Formatting.Indented);
            File.WriteAllText(Constant.FileLocationJson, json);
        }

        public void ConvertToXmlFile(List<Shape> shapes)
        {
            throw new NotImplementedException();
        }
    }
}