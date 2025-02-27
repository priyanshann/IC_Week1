
using System.Reflection.Metadata.Ecma335;
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public static class ShapeColourHelper
    {

        public static Shape AddColour(Shape s)
        {
            s.Colour = "Red";

            return s;
        }

        public static Shape ChangeColour(Shape s)
        {
            s.Colour = "Blue";

            return s;
        }

        public static Shape GetRandomColor(Shape s)
        {
            string[] colors = { "Red", "Blue", "Yellow", "Green", "Orange" };

            Random rnd = new Random();
            int index = rnd.Next(colors.Length);
            string color = (colors[index]);
            s.Colour = color;
            return s;
        }
    }
}
