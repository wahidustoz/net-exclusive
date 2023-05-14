var pointA = new Point(3, 2);
var pointB = new Point(6, 4);

var masofa = pointA.DistanceTo(pointB);

Console.WriteLine(masofa);

var circle = new Circle(new Point(-7, 6), 2);
var ichidami = circle.Contains(new Point(-7, 5));
Console.WriteLine(ichidami);