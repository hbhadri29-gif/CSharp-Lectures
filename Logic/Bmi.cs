using System;

class Bmi
{
static void Main()
{

double height,weight,f;

Console.WriteLine("Enter the Height");
height=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the Weight");
weight=Convert.ToDouble(Console.ReadLine());

f=(weight/(height*height))*703;

if(f < 18.5)
{

Console.WriteLine("You are underwieght");

}

else if( f >= 18.5 && f <= 25)
{

Console.WriteLine("You are healthy");

}

else if( f > 25)

{

Console.WriteLine("You  are overweight");

}

else
{

}
}}