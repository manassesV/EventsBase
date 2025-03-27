namespace EventsBase;

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
        _area = 3.14 * _radius * _radius;
    }

    public void Update(double d)
    {
        _radius = d;
        _area = 3.14 * _radius * _radius;
        OnShapedChanged(new ShapeEventArgs(_area));
    }

    protected override void OnShapedChanged(ShapeEventArgs e)
    {
        base.OnShapedChanged(e);
    }

    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}
