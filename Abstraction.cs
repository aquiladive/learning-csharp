//Program to show abstraction, using an abstract class Shape with two derived classes Triangle and Circle.

using System;
abstract class Shape {
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}

class Circle: Shape {
    public int rad {get; set;}
    public override double CalculateArea() {
        return rad*rad*Math.PI;
    }
    public override double CalculatePerimeter() {
        return 2*rad*Math.PI;
    }
}

class Triangle: Shape {
    public int Side1 {get; set;}
    public int Side2 {get; set;}
    public int Side3 {get; set;}
    public override double CalculateArea() {
        double s = (Side1+Side2+Side3)/2;
        return Math.Sqrt(s*(s-Side1)*(s-Side2)*(s-Side3));
    }
    public override double CalculatePerimeter() {
        return Side1+Side2+Side3;
    }
}

public class Program {
    public static void Main(String[] args) {
        Circle c = new Circle{rad=5};
        Triangle t = new Triangle{Side1=3, Side2=4, Side3=5};

        Console.WriteLine(c.CalculateArea());
        Console.WriteLine(c.CalculatePerimeter());

        Console.WriteLine(t.CalculateArea());
        Console.WriteLine(t.CalculatePerimeter());
    }
}
