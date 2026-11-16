using System;


public class yd :Exception
{
double s;
public yd(double k)
{
s=k;
}
 public override string ToString()
{
return("Negative number");
}
}                              

class flo
{
static void Main()
{
double n,d;

Console.WriteLine("ENter the number");
n= double.Parse(Console.ReadLine());

d=Math.Sqrt(n);

try{

if(d<-1)
{
throw new yd(d);
}

else{
Console.WriteLine(d);
}}
catch(yd y)
{

Console.WriteLine(y);
}
}
}

