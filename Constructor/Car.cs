using System;

class Car
{
 string brand;

Car(string thebrand)
{
brand= thebrand;
}

Car(Car bb)
{

brand = bb.brand;
}

static void Main()
{
 Car c1 = new Car("Maruti");
 
Console.WriteLine("The Brand is " + c1.brand);
 Car c2 = new Car(c1);
Console.WriteLine("The Brand is " + c2.brand);
Console.ReadLine();
}
}
