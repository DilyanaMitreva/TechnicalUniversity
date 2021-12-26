using System;
using System.IO;

namespace CourseWorkEntities.Constants
{
    public static class FileLocation
    {
        private static readonly string DesktopLocation =
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        private static readonly string ProjectDirectory =
            Directory.GetParent(Environment.CurrentDirectory)?.Parent?.FullName;

        public static readonly string FilesFolderPath = Path.Combine(ProjectDirectory, "ShapeFiles");

        public static readonly string FileLocationTxt = Path.Combine(FilesFolderPath, "shapes.txt");

        public static readonly string FileLocationJson = Path.Combine(FilesFolderPath, "shapes.json");

        public static readonly string FileLocationXml = Path.Combine(FilesFolderPath, "shapes.xml");
    }
}