using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;
using CourseWorkEntities.Constants;
using CourseWorkEntities.Exceptions;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities;
using CourseWorkEntities.Utilities.Interfaces;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;
using Rectangle = CourseWorkEntities.Shapes.Rectangle;


namespace CourseWorkVisualInterface.Services
{
    public class SerializeShapeService : ISerializeShapeService
    {
        public SerializeShapeService()
        {
            Directory.CreateDirectory(FileLocation.FilesFolderPath);
        }

        public void SerializeToTxtFile(List<Shape> shapes)
        {
            if (shapes.Count == 0)
            {
                throw new EmptyCollectionException("No items in collection");
            }

            string text = new StringBuilder()
                .AppendLine($"Shapes count: {shapes.Count}")
                .Append(Constant.ShapeSeparatorTxt)
                .Append(shapes.Select(s => s.AsString())
                    .Aggregate((f, s) =>
                        f + Constant.ShapeSeparatorTxt + s))
                .AppendLine(Constant.ShapeSeparatorTxt)
                .ToString();


            File.WriteAllText(FileLocation.FileLocationTxt, text);

            using (StreamWriter outputFile = new StreamWriter(FileLocation.FileLocationTxt))
            {
                outputFile.Write(text);
            }
        }

        public void SerializeToJsonFile(List<Shape> shapes)
        {
            if (shapes.Count == 0)
            {
                throw new EmptyCollectionException("No items in collection");
            }


            string json = JsonConvert.SerializeObject(shapes, Formatting.Indented);
            File.WriteAllText(FileLocation.FileLocationJson, json);
        }

        public void SerializeToXmlFile(List<Shape> shapes)
        {
            if (shapes.Count == 0)
            {
                throw new EmptyCollectionException("No items in collection");
            }

            Type[] extraTypes = new Type[]
                { typeof(EquilateralTriangle), typeof(Rectangle), typeof(Circle), typeof(PointImpl), typeof(Color) };

            XmlSerializer xmlSerializer = new XmlSerializer(shapes.GetType(), extraTypes);

            using (FileStream stream =
                   new FileStream(FileLocation.FileLocationXml, FileMode.OpenOrCreate, FileAccess.Write))
            {
                xmlSerializer.Serialize(stream, shapes);
            }
        }

        public void SerializeSave(List<Shape> shapes)
        {
            if (shapes.Count == 0)
            {
                throw new EmptyCollectionException("No items in collection");
            }

            var formatter = new BinaryFormatter();

            using (var fileStream = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                formatter.Serialize(fileStream, shapes);
            }
        }
    }
}