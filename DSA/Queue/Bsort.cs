using System;

class Bsort
{

int []que;
 int front ;
 int rear;
int size;

public Bsort(int len)
{
 
que = new int[len];
front =0;
rear =-1;
size=0;
}

public void En(int value)
{
if(que.Length-1 == rear )
{
Console.WriteLine("Queue is full");
return;
}

rear++;
que[rear] = value;
size++;
}

public void De()
{

if(size == 0)
{

Console.WriteLine("Quee is Empty");
return ;
}

Console.WriteLine("The removed ele are");
Console.WriteLine(que[front]);

front++;
size--;
}

public void Search(int val)
{
int j=0;
 for(int i=0;i<=rear;i++)
{
  if(que[i]==val)
{
j=j+1;
}
}
if(j>0)
{
Console.WriteLine($"The {val} appears {j} times");
}

else
{
Console.WriteLine($"{val} does not appears");
}}

public void Dis()
{
Console.WriteLine("The ele of quee are");
for(int i=front;i<=rear;i++)
{
Console.Write(que[i] + " ");
}

Console.WriteLine(" ");  
}

}

class Pro

{

static void Main()
{
Console.WriteLine("Enter the size of quee");
int a = int.Parse(Console.ReadLine());

Bsort q = new Bsort(a);
int b=int.Parse(Console.ReadLine());
int c=int.Parse(Console.ReadLine());
int d=int.Parse(Console.ReadLine());
int e=int.Parse(Console.ReadLine());

q.En(b);
q.En(c);
q.En(d);
q.En(e);

q.Dis();
Console.WriteLine("Enter the value  you wanna search");

int f=int.Parse(Console.ReadLine());
q.Search(f);

q.De();
q.De();
q.Dis();
}
}
