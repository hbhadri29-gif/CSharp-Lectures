using System;

class Trap
{

static void Main()
{

double a,b,h,f;

Console.WriteLine("Enter the area of first side");

a= Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the area of second side");
b= Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the height");

h= Convert.ToDouble(Console.ReadLine());


f=0.5*(a+b)*h;


Console.WriteLine("The area of trapezium is" + f);

}
}

