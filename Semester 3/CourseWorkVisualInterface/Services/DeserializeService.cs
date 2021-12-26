using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities.Interfaces;

namespace CourseWorkVisualInterface.Services
{
    public class DeserializeService : IDeserializeService
    {
        public List<Shape> DeserializeSave()
        {
            List<Shape> shapes;

            if (!File.Exists("data.txt"))
            {
                throw new FileNotFoundException("No file found");
            }

            var formatter = new BinaryFormatter();
            
            using (var stream = new FileStream("data.txt", FileMode.Open, FileAccess.Read))
            {
                shapes = formatter.Deserialize(stream) as List<Shape>;
            }

            return shapes;
        }
    }
}