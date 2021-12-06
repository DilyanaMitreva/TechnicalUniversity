using System.Collections.Generic;
using System.Windows.Forms;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities.Interfaces;

namespace CourseWorkEntities.Services
{
    public class MoveShapeService : IMoveShapeService
    {
        private readonly int _distance;

        public MoveShapeService()
        {
            this._distance = 5;
        }

        public MoveShapeService(int distance)
        {
            this._distance = distance;
        }

        public void Move(List<Shape> shapes, Keys button)
        {
            if (button == Keys.Up)
            {
                shapes.ForEach(MoveUp);
            }
            else if (button == Keys.Down)
            {
                shapes.ForEach(MoveDown);
            }
            else if (button == Keys.Left)
            {
                shapes.ForEach(MoveLeft);
            }
            else if (button == Keys.Right)
            {
                shapes.ForEach(MoveRight);
            }
        }

        private void MoveRight(Shape shape) => shape.Location.X += this._distance;


        private void MoveLeft(Shape shape) => shape.Location.X -= this._distance;


        private void MoveUp(Shape shape) => shape.Location.Y -= this._distance;


        private void MoveDown(Shape shape) => shape.Location.Y += this._distance;
    }
}