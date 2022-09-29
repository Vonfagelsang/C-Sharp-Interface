class Cylinder : IShape
{
    double radius = 4;
    double height = 8;
    public double Area()
    {
        return (2 * 3.14 * radius * (radius + height));
    }
    public double Circumferance()
    {
        return (4 * 3.14 * radius * radius);
    }
}