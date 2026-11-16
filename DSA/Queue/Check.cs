using System;

class Check
{

int front;
int rear;
int []que;
int []quee;
int size;

public Check(int si)
{
front=-0;
rear=-1;
size=0;
que= new int[si];
quee= new int[si];
}

public void En(int val,int value)
{
if(rear == que.Length-1 && rear == que.Length-1)
{
Console.WriteLine("Queue is full");
}

rear++;
que[rear]= val;
quee[rear]= value;
size++;
}

public void De()
{
if(size==0)
{
Console.WriteLine("Quue is empty");
}

Console.WriteLine($"The ele removed {front}");
front++;
size--;
}

public void ch()
{
int count=0;
for(int i=0;i<que.Length;i++)
{
for(int j=0;j<quee.Length;j++)
{
if(que[i]==quee[j])
{
Console.WriteLine(que[i]);
count++;
}
}
}
if(count==size)
{
Console.WriteLine("All Elements matched   " + count);
}
}
}
class Program
{
static void Main()
{
Check c = new Check(4);
c.En(4,3);
c.En(5,4);
c.En(6,5);
c.En(3,4);
c.ch();
}
}