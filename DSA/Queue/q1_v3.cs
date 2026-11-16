using System;

class Qu
{

int []quee;
int size;
int front;
int rear;

public Qu(int capa)
{
quee = new int[capa];
size =0;
front =0;
rear =-1;
}

public void En(int value)
{
if(size==quee.Length)
{
Console.WriteLine("Quee is full");
return;
}
rear++;

quee[rear]=value;
size++;
}

public void De()
{
if (size==0)
{
Console.WriteLine("Quueu is empty");
}


Console.WriteLine("The element is removed"+ quee[front]);
front++;
size--;
}

public void Dis()
{

Console.WriteLine("The ele are ");
for(int i=front;i<=rear;i++)
{
Console.Write(quee[i] + " ");
}
Console.WriteLine(" ");
}

public void Peek()
{
Console.WriteLine("The current is front is  " + quee[front]);
}
}

class Pro
{
static void Main()
{

Console.WriteLine("Enter the size of ele");
int a= int.Parse(Console.ReadLine());
Qu qt = new Qu(a);
int b= int.Parse(Console.ReadLine()); 
int c= int.Parse(Console.ReadLine());
int d= int.Parse(Console.ReadLine());
int e= int.Parse(Console.ReadLine());
int f= int.Parse(Console.ReadLine());
qt.En(b);
qt.En(c);
qt.En(d);
qt.En(e);
qt.En(f);

qt.Dis();

qt.De();
qt.Peek();

qt.De();
qt.Peek();

qt.Dis();
}
}
  