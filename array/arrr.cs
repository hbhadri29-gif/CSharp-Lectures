using System;

class arrr
{
 static void Main()
{

int []arr;
int i,n,k=0;
Console.WriteLine("Enter the size of array");
n=int.Parse(Console.ReadLine());

arr= new int[n];

for(i=0;i<n;i++)
{
Console.WriteLine("Enter the elements");
arr[i]=int.Parse(Console.ReadLine());
}

for(i=0;i<n;i++)
{
Console.Write("");
}
 for(i=n-1;i>=0;i--)
{
Console.Write(arr[i] + " ");

}
for(i=0;i<n;i++)
{
k=arr[i]+k;
}
Console.WriteLine(k);
}

}