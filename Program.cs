class Program
{
    public static void Main()
    {
        Console.Clear();
        double awnser;
        
        List<IShape> ShapeList = new List<IShape>();
        ShapeList.Add(new Triangle());
        ShapeList.Add(new Rectangle());
        ShapeList.Add(new Circle());

        Console.WriteLine("Choose 1 for Triangle or 2 for Rectangle or 3 for Circle");
        awnser = double.Parse(Console.ReadLine());

        if(awnser == 1)
        {
            Console.WriteLine("Triangle area: " + ShapeList[0].Area());
            Console.WriteLine("Triangle circumferance: " + ShapeList[0].Circumferance());
        }
        else if(awnser == 2)
        {
            Console.WriteLine("Rectangle area: " + ShapeList[1].Area());
            Console.WriteLine("Rectangle circumferance: " + ShapeList[1].Circumferance());
        }
        else if(awnser == 3)
        {
            Console.WriteLine("Circle area: " + ShapeList[2].Area());
            Console.WriteLine("Circle circumferance: " + ShapeList[2].Circumferance());
        }
    }
}