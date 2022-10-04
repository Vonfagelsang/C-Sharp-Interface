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

        Console.WriteLine("Choose 1 for Triangle or 2 for Rectangle or three for Cicrle");
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
        else if(awnser == 3)
        {
            Console.WriteLine("Area: " + ShapeList[2].Area());
            Console.WriteLine("Circumferance: " + ShapeList[2].Circumferance());
        }
    }
}