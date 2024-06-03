

// Top-level statements
IShape shape;  // Declare a variable of the interface type

shape = new Square { SideLength = 5 };
shape.CalculateArea();  // Calls Square's implementation

shape = new Circle { Radius = 2 };
shape.CalculateArea();  // Calls Circle's implementation





public interface IShape
{
    double Area { get; }
    void CalculateArea();
}


public class Square : IShape
{
    public double SideLength { get; set; }

    public double Area { get { return SideLength * SideLength; } }

    public void CalculateArea()
    {
        Console.WriteLine($"Area of Square: {Area}");
    }
}

public class Circle : IShape
{
    public double Radius { get; set; }

    public double Area { get { return Math.PI * Radius * Radius; } }

    public void CalculateArea()
    {
        Console.WriteLine($"Area of Circle: {Area}");
    }
}