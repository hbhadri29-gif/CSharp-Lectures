using System;



class Operation
{

public delegate void Del(int x,int y);
int a,b,c;

public void Add(int i,int y)
{

a=i;
b=y;
c=a+b;
Console.WriteLine(c);
}

public void Sub(int i,int y)
{

a=i;
b=y;
c=a-b;
Console.WriteLine(c);
}
public void Multi(int i,int y)
{

a=i;
b=y;
c=a*b;
Console.WriteLine(c);
}
public void divide(int i,int y)
{

a=i;
b=y;
c=a/b;

Console.WriteLine(c);
}

static void Main()
{

Console.WriteLine("Enter the values");
int j=int.Parse(Console.ReadLine());
int d=int.Parse(Console.ReadLine());
Operation op = new Operation();
Console.WriteLine("Enter which operation you wanna perform");

string oper =Console.ReadLine();

Del db;
switch (oper)

{
case "Add":
db = op.Add;
db(j,d);
break;
case "Sub":
db =op.Sub;
db(j,d);
break;
case "Multi":
 db = op.Multi;
db(j,d);
break;

case "divide":
db = op.divide;
db(j,d);
break;
default:
Console.WriteLine("Cant help much");
break;
}
}
}

 
