using System;

class Sys
{
int []arr;
int sizee;
int span;
public Sys(int size)
{
arr = new int[size];
size=0;
span=1;
}

public void Push(int value)
{
 if(sizee==arr.Length)
{
Console.WriteLine("Stack is full");
return;
}

arr[sizee]=value;
sizee++;
}

public void Pop()
{
if(sizee==0)
{
Console.WriteLine("Stack is empty");
return;
}
sizee--;
}

public void Peek()
{
Console.WriteLine("The Peek size is " + arr[sizee]);
}

public void Span()
{

int p=1;
int k=0;
for(int i=0;i<=arr.Length-1;i++)
{
for(int j=i;j>=0;j--)
{
 if(arr[i]>arr[j])
{
p=p+1;

}

}
if(p<=0)
{
span--;
}
else if(arr[i]==arr[0])
{
k=1;
}
else
{
span=span+p-k;
p=0;
k=0;
}

Console.WriteLine("The span of ele" + arr[i] + " " + span);
 }
}
}
class Program
{
static void Main()
{
Sys s = new Sys(5);
s.Push(100);
s.Push(20);
s.Push(30);
s.Push(10);
s.Push(65);

s.Span();
}
}
