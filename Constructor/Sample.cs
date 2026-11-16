using System;


class Sample
{
public string param1,param2;
static Sample()
{
Console.WriteLine("Static Constructor");
}
public Sample()
{
param1 ="Sample";
param2 = "Insta Constructor";
}
}
class Pro
{
static void Main()
{

Sample obj= new Sample();
Console.ReadLine();
}
}
