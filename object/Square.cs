//

// Top-level statements using inheritance
// Derived class (represents a specific square shape)
public class Square : Shape
{
    public double SideLength { get; set; }

    public override void CalculateArea()  // Override to calculate area for a square
    {
        Area = SideLength * SideLength;
        Console.WriteLine($"Area of Square: {Area}");
    }
}

