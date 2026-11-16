using System;

class Qu
{
int front;
int rear;
int size;
int []que;
int []quee;

public Qu(int cap)
{
front =0;
size=0;
rear=-1;
que=new int[cap];
quee=new int[cap];
}

public void En(int val)
{

if(rear==que.Length-1 && rear== quee.Length-1) 

{
Console.WriteLine("Quee is full");
return ;
}

rear++;
que[rear]=val;
size++;
}

public void De()
{
if(size==0)
{
Console.WriteLine("QUee is empty");
}

front++;
size--;
}

public void dble()
{
for(int i=0;i<que.Length;i++)
{
quee[i]=que[i]*2;
}
}

public void Display()
{
Console.WriteLine("The double of ele are");
for(int i=0;i<quee.Length;i++)
{
Console.WriteLine(quee[i]);
}
}
}

class Pro
{
static void Main()
{
Console.WriteLine("Enter the size of ele");
int a=int.Parse(Console.ReadLine());
Qu q= new Qu(a);
int b=int.Parse(Console.ReadLine());
int c=int.Parse(Console.ReadLine());
int d=int.Parse(Console.ReadLine());
q.En(b);
q.En(c);
q.En(d);

q.dble();
q.Display();
}
}
