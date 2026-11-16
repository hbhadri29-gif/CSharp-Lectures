using System;

class Que
{

int []queuee;
int size;
int rear;
int front;

public Que(int capacity)
{
queuee = new int[capacity];
size=0;
rear=-1;
front =0;

}

public void En(int value)
{

if(size==queuee.Length)
{
Console.WriteLine("Queuee is full");
return;
} 
rear++;
queuee[rear]=value;
size++;

}


public void De()
{

if(size==0)
{
Console.WriteLine("Queeue is empty");
}
Console.WriteLine("Front  element is removed" + queuee[front]);
 front++;
 size--;

}

public void Display()
{
Console.WriteLine("Queue Ele");
for(int i=0;i<=rear;i++)
{
Console.Write(+ queuee[i] +" ");
}
Console.WriteLine();
}
public void Peek()
{
Console.WriteLine("Current ele is" + queuee[front]);

}

public void Remain()
{
Console.WriteLine("Remaining ele are");
for(int i=front;i<=0;i--)
{
Console.Write(queuee[i]);
}
Console.WriteLine();
}
}
class Program
{

static void Main()
{

Que q = new Que(4);

q.En(6);
q.En(4);
q.En(5);
q.En(4);

q.Display();


q.De();
q.Remain();

q.Peek();
q.De();
q.Remain();

q.Peek();
}
}