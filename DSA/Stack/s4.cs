using System;

class Stack
{

int []arr;
int top;

public Stack(int s)
{
arr = new int[s];
top = -1;
}

public void Push(int value)
{

if(top==arr.Length-1)
{
Console.WriteLine("Stack is full");
return;
}

top++;
arr[top]=value;
}

public void Pop()
{
if(top==-1)
{
Console.WriteLine("Stack is Empty");
return;
}
top--;
}

public void Peek()
{
Console.WriteLine("The element in top is" + arr[top]);
}

public void Display()
{
Console.WriteLine("All the ele are");
for(int i=0;i<=top;i++)
{
Console.Write(arr[i] + " ");
}
}

public void Small()
{
int h=0; 
int a=arr[0];
int b=arr[1];
int temp=0;
if(b<a)
{
a=a+b;
b=a-b;
a=a-b;
}

for(int i=2;i<=top;i++)
{
if(arr[i]<a)
{
b=a;
a=arr[i];

}
else if(arr[i]<b)
{
b=arr[i];
}

}
Console.WriteLine("second smallest is are" + b);
}
}
class Program()
{
static void Main()
{
Console.WriteLine("Enter the size of stack");
int n= int.Parse(Console.ReadLine());
Stack r = new Stack(n);
Console.WriteLine("Enter the ele you wanna store");
int c=int.Parse(Console.ReadLine());
int d=int.Parse(Console.ReadLine());
int e=int.Parse(Console.ReadLine());
int f=int.Parse(Console.ReadLine());
int i=int.Parse(Console.ReadLine());
r.Push(c);
r.Push(d);
r.Push(e);
r.Push(f);
r.Push(i);

r.Display();
r.Peek();
r.Pop();

r.Display();
r.Peek();

r.Small();
}
}