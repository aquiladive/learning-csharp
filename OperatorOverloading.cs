//Design a class "Complex" with data members, constructor and method for overloading a binary operator '+'. Develop a C# program to read two complex numbers and print the results of addition.

using System;
class Complex {
  int real, img;
  public Complex(int a=0, int b=0) {
    real=a;
    img=b;
  }
  public static Complex operator +(Complex c1, Complex c2) {
    Complex temp = new Complex();
    temp.real = c1.real + c2.real;
    temp.img = c1.img + c2.img;
    return temp;
  }

  public void Display() {
    Console.WriteLine($"{real}+{img}i");
  }
}

public class OperatorOverloading {
  public static void Main(string[] args) {
    int i, j, k, l;
    Console.Write("Give real part of first complex number: ");
    i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Give imaginary part of first complex number: ");
    j = Convert.ToInt32(Console.ReadLine());
    Console.Write("Give real part of second complex number: ");
    k = Convert.ToInt32(Console.ReadLine());
    Console.Write("Give imaginary part of second complex number: ");
    l = Convert.ToInt32(Console.ReadLine());
    Complex c1 = new Complex(i, j);
    Complex c2 = new Complex(k, l);
    Complex c3 = c1+c2;
    Console.Write("Sum of the two numbers is: ");
    c3.Display();
  }
}
