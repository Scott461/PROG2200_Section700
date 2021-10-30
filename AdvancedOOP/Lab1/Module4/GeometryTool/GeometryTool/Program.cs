using System;

namespace GeometryTool 
{
    class Program {
        static void Main(string[] args) 
        {
            var triangle = new Triangle() { Base = 3.6, Height = 5 }; // create the shaped
            var square = new Square() {Width = 5.5 };
            var circle = new Circle() {Radius = 4 };

            triangle.Display(); // display area
            square.Display();
            circle.Display();
            Console.Read(); // pause so we can read
        }
    }
   
}

public abstract class Shape // abstract class
    {
    public abstract double getArea(); // overide this function

    public void Display() // this function is common to all shapes
    {
        Console.WriteLine("This area is: {0}", getArea());   
    }
}

public class Square : Shape // square 
{
    public double Width;

    public override double getArea() 
    {
        return Width * Width;
    }
}

public class Triangle : Shape // triangle
{
    public double Base;
    public double Height;

    public override double getArea() {
        return Base /  2 * Height;
    }
}

public class Circle : Shape // circle
{

    public override double getArea() {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public double Radius;
}