using System;

class Cons
{
int c;
public Cons()
{
	c=9999;
}
public Cons(int q)  //Parameterised constructor
{
	c=q;
}

public Cons(int x,int y)
{

c=x+y;

}
public void Func(int a, int b)  //No return and with arguments
{
c=a+b;
Console.WriteLine(c);
}
public int Func()  //No parameter and with return type
{
return(100);
}
public int Func(int m) //Parameters and with return type
{
return(m*m*m);
}
void Show()
{
	Console.WriteLine("Value of c  is "+c);
}
public static void Main()
{
Cons hh = new Cons();
hh.Show();
Cons hh1=new Cons(9);
hh1.Show();
Cons hh2 = new Cons(10,9);
hh2.Show();
/*
int x,y;
Console.WriteLine("Enter the a");
x=int.Parse(Console.ReadLine());
Console.WriteLine("Enter the b");
y=int.Parse(Console.ReadLine());
hh.Func(x,y);
*/
}
}