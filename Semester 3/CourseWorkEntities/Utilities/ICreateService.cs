using CourseWorkEntities.Shapes;

namespace CourseWorkEntities.Utilities
{
    public interface ICreateService
    { 
        Shape createRectangle(int xPosition, int yPosition, double height, double lenght);

        Shape createCircle(int xPosition, int yPosition, double radius);

        Shape createTriangle(int xPosition, int yPosition, double side);
    }
}