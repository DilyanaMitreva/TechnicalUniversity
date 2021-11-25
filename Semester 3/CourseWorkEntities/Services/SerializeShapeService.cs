﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities;
using CourseWorkEntities.Utilities.Interfaces;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;
using Rectangle = CourseWorkEntities.Shapes.Rectangle;


namespace CourseWorkEntities.Services
{
    public class SerializeShapeService : ISerializeShapeService
    {
        public void SerializeToTxtFile(List<Shape> shapes)
        {
            if (shapes.Count == 0)
            {
                return;
            }

            string text = new StringBuilder()
                .Append($"Shapes count: {shapes.Count}" + Constant.ShapeSeparatorTxt)
                .Append(shapes.Select(s => s.AsString())
                    .Aggregate((f, s) =>
                        f + Constant.ShapeSeparatorTxt + s))
                .AppendLine(Constant.ShapeSeparatorTxt)
                .ToString();


            File.WriteAllText(Constant.FileLocation.FileLocationTxt, text);

            using (StreamWriter outputFile = new StreamWriter(Constant.FileLocation.FileLocationTxt))
            {
                outputFile.Write(text);
            }
        }

        public void SerializeToJsonFile(List<Shape> shapes, string location)
        {
            if (shapes.Count == 0)
            {
                return;
            }

            string json = JsonConvert.SerializeObject(shapes, Formatting.Indented);
            File.WriteAllText(location, json);
        }

        public void SerializeToXmlFile(List<Shape> shapes)
        {
            if (shapes.Count == 0)
            {
                return;
            }

            Type[] extraTypes = new Type[]
                { typeof(EquilateralTriangle), typeof(Rectangle), typeof(Circle), typeof(PointImpl), typeof(Color) };

            XmlSerializer xmlSerializer = new XmlSerializer(shapes.GetType(), extraTypes);

            using (FileStream stream =
                new FileStream(Constant.FileLocation.FileLocationXml, FileMode.OpenOrCreate, FileAccess.Write))
            {
                xmlSerializer.Serialize(stream, shapes);
            }
        }
    }
}