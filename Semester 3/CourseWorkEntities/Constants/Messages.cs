namespace CourseWorkEntities.Constants
{
    public class Messages
    {
        public static readonly string SaveMessage = "Canvas is saved";
        
        public static class ExceptionMessages
        {
            public const string RadiusMessage = "Enter radius";

            public const string PositiveNumberMessage = "Enter a positive integer";

            public const string SideMessage = "Enter triangle side";

            public const string HeightMessage = "Enter height";

            public const string WidthMessage = "Enter width";

            public const string NumberMessage = "Enter a number";

            public const string XCoordinateMessage = "Enter X coordinate";

            public const string YCoordinateMessage = "Enter Y coordinate";

            public const string ChooseShapeMessage = "Choose a shape";

            public const string EmptyListMessage = "No items";

            public const string SelectTypeForExport = "Select type of export";

            public const string ShapeNotSupported = "Shape not supported";
        }

        public static class AreaTemplateMessages
        {
            public const string AllAreaMessage = "The total used area is {0:N2} pixels.";

            public const string AllAreaOfTypeMessage =
                "The total area of all {0}s is {1:N2} pixels.";

            public const string BiggestAreaMessage = "The biggest area of all shapes is {0:N2} pixels.";

            public const string BiggestAreaOfTypeMessage = "The biggest {0} has area of {1:N2} pixels.";

            public const string SmallestAreaMessage = "The smallest area of all shapes is {0:N2} pixels.";

            public const string SmallestAreaOfTypeMessage = "The smallest {0} has area of {1:N2} pixels.";

            public const string UnusedSpaceMessage =
                "The unused area of the scene is {0:N2} pixels.";
        }
    }
}