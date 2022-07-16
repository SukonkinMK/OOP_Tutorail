using Homework6;

Figure f1 = new Figure();
Figure f2 = new Figure("red", false);
f1.Print();
f2.Print();

Point p1 = new Point();
Point p2 = new Point(5, 5, "red", true);

p1.ChangeColor("green");
p1.Move(3, Direction.Up);

Circle c1 = new Circle();
Circle c2 = new Circle(3, 1, 4, "blue", false);
c2.Move(1, Direction.Right);
c1.ChangeColor("black");

Rectangle r1 = new Rectangle();
Rectangle r2 = new Rectangle(2, 3, 5, 10, "orange", true);
r1.Move(1, Direction.Left);
r2.ChangeColor("white");
Console.ReadLine();