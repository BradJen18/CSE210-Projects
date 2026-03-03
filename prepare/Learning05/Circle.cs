class Circle : Shapes
{
    private double _radius;

    public override double GetArea()
    {
        return Math.PI*Math.Pow(_radius,2);
    }

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
}