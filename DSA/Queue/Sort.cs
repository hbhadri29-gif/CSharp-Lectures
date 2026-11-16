using System;

class Qu
{
int front;
int size;
int rear;
int []qu;
int []que;
int []queu;

public Qu(int cap)
{
front=0;
rear=-1;
size=0;
qu = new int[cap];
que = new int[cap];
queu = new int[cap*2];
}

public void En(int val)
{
if(rear== qu.Length-1 )
{
Console.WriteLine("Quee size is full");
}
 rear++;
 qu[rear]=val;
 
 size++;
}

public void De()
{
if (size==0)
{
Console.WriteLine("Quee is empty");
}
front++;
size--;
}

public void Sort()
{
int a;
a=qu[0];
for(int i=0;i<qu.Length;i++)
{

if(a>qu[i])
{
a=qu[i];
}

}
for(int i=0;i<qu.Length;i++)
{
if(a!=qu[i])
{
que[i]=qu[i];
Console.WriteLine(que[i]);
}
}
}
}
class Program()
{
static void Main8                                             i()
{

Qu q= new Qu(3);

q.En(12);
q.En(15);
q.En(5);

q.Sort();
}
}