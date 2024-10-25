using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Blue", 8);
        shapes.Add(square);
        
        Rectangle rectangle = new Rectangle("Red", 9, 5);
        shapes.Add(rectangle);
      
        Circle circle = new Circle("Green", 12);
        shapes.Add(circle);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The color is {color}, and its shape has an area of: {area}.");
        }
    }
}