class Program
{
    public static void Main()
    {
        Console.Clear();
        double awnser;
        Console.WriteLine("Write the width");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Write  the height");
        double height = double.Parse(Console.ReadLine());
        
        List<IShape> ShapeList = new List<IShape>();
        ShapeList.Add(new Triangle());
        ShapeList.Add(new Rectangle());
        Console.WriteLine("Choose 1 for Triangle or 2 for Rectangle");
        awnser = double.Parse(Console.ReadLine());

        if(awnser == 1)
        {
            Console.WriteLine("Area: " + ShapeList[0].Area());
            Console.WriteLine("Circumferance: " + ShapeList[0].Circumferance());
        }
        else if(awnser == 2)
        {
            Console.WriteLine("Area: " + ShapeList[1].Area());
            Console.WriteLine("Circumferance: " + ShapeList[1].Circumferance());
        }
    }
}