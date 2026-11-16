using System;

class Quu
{

int front;
int rear;
int size;
int []quu;
int []que;
int []quy;

public Quu(int capa,int capa1)
{
quu = new int[capa];
que = new int[capa1];
quy = new int[capa + capa1];
front =0;
rear=-1;
size=0;
}
public void En(int val, int val1)
{
 
if(rear == quu.Length-1 && rear == que.Length-1)
{

Console.WriteLine("Quee is full");
 return;

}

rear++;
quu[rear]=val;
que[rear]=val1;
size++;
}

public void De()
{
if(size==0)
{
Console.WriteLine("Quee is Empty");
return;
}

Console.WriteLine($"The ele which will be get removed ${quu[front]} and  ${que[front]}");
 size--;
 front++;

}

public void Merge()
{
 for( int i=0;i<size;i++)
{
quy[i]=quu[i];
}
}


public void Merge1()
{
int j=0;
 for( int i=size;i<quy.Length;i++)
{
quy[i]=que[j++];
}
}

public void Display()
{
Console.WriteLine("The ele in 3 quee are");
for(int i=0;i<quy.Length;i++)
{
Console.Write(quy[i] + " ");
}
}

}

class Pro()
{
static void Main()
{
Quu q = new Quu(4,4);

q.En(5,5);
q.En(5,7);
q.En(3,4);
q.En(1,2);
 
q.Merge();
q.Merge1();

q.Display();
}
}