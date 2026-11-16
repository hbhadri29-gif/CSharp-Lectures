using System;

class com
{

static void Main()
{
int m=1;
int []arr;
 
int i,n,k=0;

Console.WriteLine("Enter the size of array");

n= int.Parse(Console.ReadLine());

arr = new int[n];

for(i=0;i<n;i++)
{  

Console.WriteLine("Enter the array elemen" + m);
arr[i]= int.Parse(Console.ReadLine());
m=m+1;

}


for(i=0;i<n;i++)
{  

Console.WriteLine("The arry ele are" + arr[i]);
}

for(i=0;i<n;i++)
{
for(i=0;i<n;i++)
{ if(arr[k]!=arr[i])
Console.WriteLine( arr[i]);

}
k=k+1;
}
}}