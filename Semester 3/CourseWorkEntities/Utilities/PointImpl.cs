using System.Text;

namespace CourseWorkEntities.Utilities
{
    public class PointImpl
    {
        public int X { get; set; }

        public int Y { get; set; }

        public PointImpl()
        {
        }

        public PointImpl(int x, int y)
        {
            X = x;
            Y = y;
        }

        public string AsString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine()
                .AppendLine($"\t X coordinate: {this.X}")
                .AppendLine($"\t Y coordinate: {this.Y}");

            return sb.ToString();
        }
    }
}