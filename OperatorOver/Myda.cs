using System;

class Myda
{

int Val;
public  Myda(int val)
{
Val=val;

}

public static Myda operator +(Myda a,Myda b)
{

return new Myda(a.Val + b.Val);
}

public static Myda operator -(Myda a,Myda b)
{

return new Myda(a.Val - b.Val);
}

static void Main()
{

int c= int.Parse(DateTime.Today.ToString("yyyyMMdd"));
int d=int.Parse(Console.ReadLine());

Myda c1= new Myda(c);
Myda c2= new Myda(d);
Myda c3= c1+c2;
Myda c4= c1-c2;

int op=1;

switch(op)
{

case 1:

Console.WriteLine(c3.Val);
break;

case 2:
Console.WriteLine(c4.Val);
break; 

default:
Console.WriteLine("Wrong");
break;
}
}
} 