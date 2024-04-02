Rectangle rectangle = new(10, 20);

Console.WriteLine(rectangle.CalculateArea());
Console.WriteLine(rectangle.CalculatePerimeter());

class Rectangle
{
    private double _length { get; set; }
    private double _width { get; set; }

    public Rectangle(double length, double width)
    {
        _length = length;
        _width = width;
    }

    public double CalculateArea()
    {
        return _length * _width;
    }
    public double CalculatePerimeter()
    {
        return 2*(_length+_width);
    }
}