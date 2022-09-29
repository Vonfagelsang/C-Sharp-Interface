class Triangle : IShape
{
    double width = 7;
    double height = 3;
    public double Area()
    {
        return (width * height) / 2;
    }
    public double Circumferance()
    {
        return (width * 3);
    }
}