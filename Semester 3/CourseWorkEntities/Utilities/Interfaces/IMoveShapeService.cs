using System.Collections.Generic;
using System.Windows.Forms;
using CourseWorkEntities.Shapes;

namespace CourseWorkEntities.Utilities.Interfaces
{
    public interface IMoveShapeService
    {
        void Move(List<Shape> shapes, Keys button);
    }
}