abstract class Animal
{
    // Abstract method (does not have a body)
    public abstract void MakeSound();

    // Regular method
    public void Sleep()
    {
        Console.WriteLine("Zzz");
    }
}
