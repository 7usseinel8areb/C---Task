


class Rectangle : Shape
{
    private double _length { get; set; }
    private double _width { get; set; }

    public Rectangle(double length, double width)
    {
        _length = length;
        _width = width;
    }
    public override double CalculateArea()
    {
        return _length * _width;
    }
}