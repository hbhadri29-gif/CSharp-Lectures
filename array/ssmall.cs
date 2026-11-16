using System;

class ssmall

{
 static void Main()
{

int []arr;

int i,n,k;

Console.WriteLine("Enter the size of array");
n = int.Parse(Console.ReadLine());
arr = new int[n];

Console.WriteLine("Enter the array elements");

for(i=0;i<n;i++)
{

arr[i]= int.Parse(Console.ReadLine());
}
Console.WriteLine("array elements are");

for(i=0;i<n;i++)
{

Console.WriteLine(arr[i]);
}
int p=arr[1];
k=arr[0];

for(i=0; i<n;i++)
{
 if(arr[i]<=k)
{
  k=arr[i];
}

}
for(i=0; i<n;i++)
{
 if(arr[i]<=k)
{
  k=arr[i];
}
}
{for(i=0; i<n;i++)
if(k<arr[i] && p>=arr[i])
{
p=arr[i];
} 
}
Console.Write("the value of 2 small is " + p);
}
}