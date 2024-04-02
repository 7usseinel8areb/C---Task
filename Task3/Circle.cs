


class Circle : Shape
{
    private double pi = Math.PI;
    private double _radius { get; set; }

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double CalculateArea()
    {
        return pi * _radius * _radius;
    }
}