using System.Collections.Generic;
using System.IO;
using System.Text;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities;
using CourseWorkEntities.Utilities.Interfaces;
using Newtonsoft.Json;

namespace CourseWorkEntities.Services
{
    public class DeserializeShapeService : IDeserializeShapeService
    {
        public List<Shape> DeserializeFromJsonFile() // TODO
        {
            // List<Shape> shapes = new List<Shape>();
            //
            // if (!File.Exists(Constant.FileLocation.FileLocationJsonSave))
            // {
            //     throw new FileNotFoundException("No file found");
            // }
            //
            // shapes = JsonConvert.DeserializeObject(
            //     File.ReadAllText(Constant.FileLocation.FileLocationJsonSave)) as List<Shape>;

            return null;
        }
    }
}