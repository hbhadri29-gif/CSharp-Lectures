using System;

class PQueue
{
int capa;
int []que;
int []prio;
int size;

public PQueue(int capa)
{
this.capa =capa;
que= new int[capa];
prio = new int[capa];
size=0;
}

public void En( int value, int prior)
{

 if(size==capa)
{
Console.WriteLine("Queue is full");
return;
}

que[size]=value;
prio[size]=prior;
size++;
}

public int Hi()
{
int index=0;

for(int i=1;i<size;i++)
{
if(prio[i]<prio[index])
{

index=i;

}

}
return index;
}

public void De()
{
if(size==0)

{
Console.WriteLine("Empty");
return;
}

int index=Hi();
Console.WriteLine($"value removed {que[index]} priority {prio[index]}");
for(int i=index;i<size-1;i++)
{
que[i] = que[i+1];
prio[i] = prio[i+1];
}
size--;
}

public void Dis()
{

for(int i=0;i<size;i++)
{
Console.WriteLine(que[i]);
}
}

}

class Pro()
{
static void Main()
{

PQueue e = new PQueue(4);

e.En(45,2);
e.En(11,3);
e.En(22,1);
e.En(11,4);

e.Hi();
e.De();
e.Dis();
}
}