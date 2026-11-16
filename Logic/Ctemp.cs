using System;

class Ctemp()

{

static void Main()
{

double Cel,Far,Kel;

Console.WriteLine("Enter the temp Celsius");
Cel= Convert.ToDouble(Console.ReadLine());


Far =(Cel*9/5)+32;

Kel = Cel + 273.15;

Console.WriteLine("The temp in Fahrenheit" +  Far);
Console.WriteLine("The tem in Kelvin" + Kel);
}
}
