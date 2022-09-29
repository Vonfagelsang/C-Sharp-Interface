class Rectangle : IShape
{
    double width = 10;
    double height = 5;
    public double Area()
    {
        return (width * height);
    }
    public double Circumferance()
    {
        return (width * 2) + (height * 2);
    }
}