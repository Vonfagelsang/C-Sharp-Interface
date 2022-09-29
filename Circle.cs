class Circle : IShape
{
    double radius = 7;
    double Diameter = 14;
    public double Area()
    {
        return (3.14 * radius * radius);
    }
    public double Circumferance()
    {
        return (2 * 3.14 * radius);
    }
}