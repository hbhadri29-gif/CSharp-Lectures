using System;

namespace Arthi
{

public class Ao 
{
 int n1,n2,n3;

public void Add()
{
Console.WriteLine("Add 2 numbers");
n1=int.Parse(Console.ReadLine());
n2=int.Parse(Console.ReadLine());
n3=n1+n2;
Console.WriteLine("Result is " + n3);
}

public void Multi(int a,int b)
{

n3=a*b;
Console.WriteLine("Result is " + n3);
}
public int Div()
{
Console.WriteLine("Add 2 numbers");
n1=int.Parse(Console.ReadLine());
n2=int.Parse(Console.ReadLine());
n3=n1+n2;
return(n1/n2);
}

public int sub(int c1,int c2)
{
return(c1-c2);

}

}}
