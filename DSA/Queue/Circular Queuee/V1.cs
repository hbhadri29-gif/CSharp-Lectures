using System;

class Cque

{
private int[] que;
private int front;
private int rear;
private int size;

public Cque(int ssize)
{
size=ssize;
que = new int[size];
front =-1;
rear =-1;

}

public bool IsFull()
{

return (rear+1)%size==front;

}

public bool IsEmpty()
{
return front==-1;

} 


public void En(int val)
{
if(IsFull())
{
Console.WriteLine("Quee is overflow");
return;
}

if(front==-1)
{
front=0;
}

rear = (rear+1) % size;
que[rear] = val;
Console.WriteLine($"En : {val}");
}

public void De()
{
if(IsEmpty())
{
Console.WriteLine("Queeu is underflow");
return;
}
int item=que[front];
if(front==rear)
{
rear=-1;
front=-1;
}

else
{
front =(front+1) % size;

}
Console.WriteLine($"De: {item}");
}


public void Display()
{
if(IsEmpty())
{
Console.WriteLine("Quueu is Empty");
return;
}

Console.WriteLine("Queue ele");
for(int i=front;i<=rear;i++)
{
Console.WriteLine(que[i]);
if(i==rear)
{
break;
}
}
Console.WriteLine(" ");
}

}
class Pro
{
static void Main()
{
Cque q=  new Cque(4);

q.En(4);
q.En(3);
q.En(5);
q.En(7);

q.Display();

q.En(4);
q.En(4);
q.De();
q.De();
q.De();

q.Display();
q.En(9);
q.En(9);
q.Display();
}
}
