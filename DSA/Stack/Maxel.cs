using System;

class Mzx
{

int top;
int []arr;
int []arr1;
int []arr2;
int []val;

public Mzx(int n)
{
arr = new int[n];
arr1 = new int[n];
arr2 = new int[n];
top=-1;
}

public void Push(int value,int value1, int value2)
{

if(top==arr.Length-1)
{
Console.WriteLine("Stack is full");
return;
}
top++;
arr[top]=value;
arr1[top]=value1;
arr2[top]=value2;
}

public void Mx()
{
int a=arr[0];
int b=arr1[0];
int c=arr2[0];
int j=0;
val =new int[3];
for(int i=0;i<arr.Length;i++)
{
if(arr[i]>a)
{
a=arr[i];
}
}
val[0]=a;
for(int i=0;i<arr1.Length;i++)
{
if(arr[i]>b)
{
b=arr1[i];
}
}
val[1]=b;
for(int i=0;i<arr2.Length;i++)
{
if(arr[i]>c)
{
c=arr2[i];
}
}
val[2]=c;
}

public void Display()
{
Console.WriteLine("all 3 arrays ele are");
for(int i=0;i<arr.Length;i++)
{
Console.Write(arr[i] + " ");
Console.WriteLine();
Console.Write(arr1[i] + " ");
Console.WriteLine();
Console.Write(arr2[i] + " ");
}

Console.WriteLine("the max ele are");
for(int i=0;i<val.Length;i++)
{
Console.Write(val[i] + " ");
}
}

}

class Program
{
static void Main()
{
Mzx m = new Mzx(5);
m.Push(21,22,34);
m.Push(29,53,54);
m.Push(12,52,24);
m.Push(45,23,89);
m.Push(12,34,84);

m.Mx();
m.Display();
}
}