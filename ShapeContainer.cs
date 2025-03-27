namespace EventsBase;

public class ShapeContainer
{
    private readonly List<Shape> _list;

    public ShapeContainer()
    {
        _list = new List<Shape>();
    }


    public void AddShape(Shape shape)
    {
        _list.Add(shape);

        shape.ShapeChanged += HandleShapeChanged;
    }

    private void HandleShapeChanged(object sender, ShapeEventArgs e)
    {
        if (sender is Shape shape)
        {
            // Diagnostic message for demonstration purposes.
            Console.WriteLine($"Received event. Shape area is now {e.NewArea}");

            shape.Draw();
        }
    }
}



