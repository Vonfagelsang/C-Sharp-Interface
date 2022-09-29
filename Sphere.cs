class Sphere : IShape
{
    double radius = 10;
    double Diameter = 20;
    public double Area()
    {
        return (4 / 3 * 3.14 * radius * radius * radius);
    }
    public double Circumferance()
    {
        return (4 * 3.14 * radius * radius);
    }
}