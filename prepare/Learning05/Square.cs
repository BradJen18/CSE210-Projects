class Square : Shapes
{
    private double _side;

    public override double GetArea()
    {
        return _side*2;
    }

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
}