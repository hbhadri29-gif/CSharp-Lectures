using System;

class Cinter

{
 static void Main()

{

double p,r,n,t,f,g;

Console.WriteLine("Enter the Principal Amount");
p = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the  rate of interest");

r = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the number of interest copunded per year");

n = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the time");


t = Convert.ToDouble(Console.ReadLine());




f=p*(1+r/n);
g=Math.Pow(f,n*t);


Console.WriteLine("Compund interest is" + g);

}
}

