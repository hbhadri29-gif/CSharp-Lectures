using System;

class Pro1
{

public static double pwr(double a, double b)
{
double result=1;
for(int i=1;i<=b;i++)
{


 result *=a;


}
return result;
}

static void Main()
{

double s1= pwr(3,2);
Console.WriteLine("The result is " + s1);
}
} 