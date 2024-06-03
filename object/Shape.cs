//

// Top-level statements using inheritance
// Base class (represents a generic shape)
public class Shape
{
    public double Area { get; set; }

    public virtual void CalculateArea()  // Virtual method for calculating area (can be overridden)
    {
        // Default implementation (can be overridden by derived classes)
        Console.WriteLine("Area calculation not implemented for base Shape class.");
    }
}

