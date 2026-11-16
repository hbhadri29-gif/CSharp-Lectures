using System;

class eve
{

static void Main()

{

int []arr;

int i,n,k;

Console.WriteLine("Enter the size of array");
n= int.Parse(Console.ReadLine());

arr= new int[n];

Console.WriteLine("Enter the array elements");

for(i=0;i<n;i++)
{
arr[i]=int.Parse(Console.ReadLine());
}

for(i=0;i<n;i++)
{
Console.Write(arr[i] + " ");
}
int j=arr[0];
for(i=1;i<n;i++)
{
  if(arr[i] % 2 !=0) 
  { 
     if(arr[i]>j)
     j=arr[i];
}
}
Console.WriteLine("The largest odd elem is" + j);

}
}
