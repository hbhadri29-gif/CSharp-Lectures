using System;

class arrt

{
static void Main()

{

int []arr;
int x=1,s=0;
int n,i,k;

Console.WriteLine("Enter the size of array");
n= int.Parse(Console.ReadLine());

arr = new int[n];

Console.WriteLine("Enter th ele");
for(i=0; i<n; i++)
{
arr[i]=int.Parse(Console.ReadLine());
}

for(i=0; i<n; i++)
{
Console.Write(arr[i] + " ");
}

Console.WriteLine("enter the elemnt to find");
k=int.Parse(Console.ReadLine());
for(i=0; i<n; i++)
{
if(arr[i]==k)
{s=s+1;
x=0;
Console.WriteLine("Number is found in element and found " + s + "times" );
}

}
if(x==1)
{
Console.WriteLine("number not found");
}
}
}
