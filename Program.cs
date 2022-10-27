public enum Form{
    Triangle,
    Rectangle,
    Circle, 
    Sphere, 
    Cylinder    
}
class Program
{
    public static void Main()
    {
        Console.Clear();
        Form triangle = Form.Triangle;
        Form rectangle = Form.Rectangle;
        int z = (int)Form.Circle;
        int a = (int)Form.Sphere;
        int b = (int)Form.Cylinder;
        int awnser;
        
        List<IShape> ShapeList = new List<IShape>();
        ShapeList.Add(new Triangle());
        ShapeList.Add(new Rectangle());
        ShapeList.Add(new Circle());
        ShapeList.Add(new Sphere());
        ShapeList.Add(new Cylinder());


        Console.WriteLine("Choose 1 for Triangle or 2 for Rectangle or 3 for Circle or 4 for Sphere or 5 for Cylinder");
        awnser = int.Parse(Console.ReadLine());

        if((triangle & Form.Triangle) == Form.Triangle)
        {
            Console.WriteLine("Triangle area: " + ShapeList[0].Area());
            Console.WriteLine("Triangle circumferance: " + ShapeList[0].Circumferance());
        }
        else if(rectangle & Form.Rectangle) == Form.Rectangle)
        {
            Console.WriteLine("Rectangle area: " + ShapeList[1].Area());
            Console.WriteLine("Rectangle circumferance: " + ShapeList[1].Circumferance());
        }
        else if(awnser == z)
        {
            Console.WriteLine("Circle area: " + ShapeList[2].Area());
            Console.WriteLine("Circle circumferance: " + ShapeList[2].Circumferance());
        }
        else if(awnser == a)
        {
            Console.WriteLine("Sphere area: " + ShapeList[3].Area());
            Console.WriteLine("Sphere circumferance: " + ShapeList[3].Circumferance());
        }
        else if(awnser == b)
        {
            Console.WriteLine("Cylinder area: " + ShapeList[4].Area());
            Console.WriteLine("Cylinder circumferance: " + ShapeList[4].Circumferance());
        }
    }
}