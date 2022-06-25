namespace SimpleFigureAreas;

public class Circle : Figure
{
    private uint _radius;
    
    public uint Radius
    {
        get => _radius;
        set
        {
            if (value == 0)
                throw new ArgumentException("Radius cannot be equal to zero.");
            _radius = value;
        }
    }
    
    public Circle(uint radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override string ToString()
    {
        return $"Circle with Radius = {Radius}";
    }
}