using System;

class logic

{
static void Main()
{

int []arr;

int i,n;

Console.WriteLine("Enter the size of array");
n=int.Parse(Console.ReadLine());
arr = new int[n];

Console.WriteLine("Enter the elements of array");
for(i=0;i<n;i++)
{
arr[i]=int.Parse(Console.ReadLine());
}
int j;
int f=0;
int count=1;

for(i=0;i<arr.Length;i++)
{



 if(i<arr.Length-1 && arr[i]==arr[i+1])
{
count = count+1;
}

else
{
Console.WriteLine($" arr appeared {arr[i]} times  {count}");
count=1;
}
}
Console.ReadLine();
}
}


