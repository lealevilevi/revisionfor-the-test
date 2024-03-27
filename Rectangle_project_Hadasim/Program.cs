namespace Rectangle_project_Hadasim
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //TriangleTower t = new TriangleTower(5,4);
            //t.Draw();
            int option;
            do
            {
                int width, height;
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. A rectangular tower");
                Console.WriteLine("2.  A triangle tower");
                Console.WriteLine("3. exit");
                option = int.Parse(Console.ReadLine());
           
                switch (option)
                {
                    case 1:
                        Console.WriteLine("enter height");
                        height = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter width");
                        width = int.Parse(Console.ReadLine());
                        RectangleTower r=new RectangleTower(width,height);
                        if(Math.Abs(height-width)>5)
                        {
                            r.CalcArea();   
                        }
                        else
                        {
                            r.CalcPerimeter();
                        }
                        break;
                    case 2:
                        Console.WriteLine("enter height");
                        height = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter width");
                        width = int.Parse(Console.ReadLine());
                        TriangleTower t=new TriangleTower(width,height);
                        int op2;
                        Console.WriteLine("Select an option:");
                        Console.WriteLine("enter 1 to calcPerimeter");
                        Console.WriteLine("enter 2 to draw the triangle");
                        op2=int.Parse(Console.ReadLine());
                        switch(op2)
                        {
                            case 1:
                                t.CalcPerimeter();
                                break;
                            case 2:
                                t.Draw();
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("exit");
                        break;
                    default:
                        Console.WriteLine("not valid option please try again");
                        break;
                }
            } while (option != 3);
        }
    }
}