using EventsBase;

var circle = new Circle(54);
var rectangle = new Rectangle(54, 9);
var container = new ShapeContainer();

container.AddShape(circle);
container.AddShape(rectangle);


// Cause some events to be raised.
circle.Update(57);
rectangle.Update(7, 7);
