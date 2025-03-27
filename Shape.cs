namespace EventsBase;

public abstract class Shape
{
    protected double _area;

    public double Area
    {
        get => _area;
        set => _area = value;
    }

    // The event. Note that by using the generic EventHandler<T> event type
    // we do not need to declare a separate delegate type.

    public EventHandler<ShapeEventArgs> ShapeChanged;

    public abstract void Draw();

    //The event-invoking method that derived classes can override.
    protected virtual void OnShapedChanged(ShapeEventArgs e)
    {
        ShapeChanged.Invoke(this, e);
    }

}
