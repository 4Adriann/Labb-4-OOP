Circle C1 = new Circle(5);
Circle C2 = new Circle(6);
C1.GetArea();
C2.GetArea();

Console.WriteLine(C1.GetArea());
Console.WriteLine(C2.GetArea());

class Circle
{
    int radius;
    double area;

    public Circle(int r)
    {
        radius = r;
    }

    public double GetArea()
    {
        area = Math.PI * radius * radius;
        return area;
    }
}