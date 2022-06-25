namespace SimpleFigureAreas;

using System.Linq;

public class Triangle : Figure
{
    private (uint first, uint second, uint third) _sides;

    public (uint first, uint second, uint third) Sides
    {
        get => _sides;
        set
        {
            if (value.first == 0 || value.second == 0 || value.third == 0)
                throw new ArgumentException("Triangle side cannot be equal to zero.");
            if (value.first + value.second <= value.third ||
                value.first + value.third <= value.second ||
                value.second + value.third <= value.first)
                throw new ArgumentException("Triangle with specified sides does not exist.");
            _sides = value;
        }
    }

    public bool IsRight
    {
        get
        {
            var sides = new[] {Sides.first, Sides.second, Sides.third};
            Array.Sort(sides);
            uint a = sides[0], b = sides[1], c = sides[2];
            
            long cbDiff = c - b;
            long cbSum = c + b;

            long div1 = Utils.Gcd(a, cbDiff);
            long div2 = Utils.Gcd(cbSum, a);

            return a / div1 == cbSum / div2 && cbDiff / div1 == a / div2;
        }
    }

    public uint Perimeter => Sides.first + Sides.second + Sides.third;

    public Triangle((uint first, uint second, uint third) sides)
    {
        Sides = sides;
    }
    
    public override double GetArea()
    {
        double halfPerim = Perimeter / 2.0;
        return Math.Sqrt(halfPerim * (halfPerim - Sides.first) * (halfPerim - Sides.second) * (halfPerim - Sides.third));
    }

    public override string ToString()
    {
        return $"Triangle with sides ({Sides.first}, {Sides.second}, {Sides.third})";
    }
}