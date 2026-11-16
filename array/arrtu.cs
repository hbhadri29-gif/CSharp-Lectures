using System;

class arrtu

{

static void Main()

{

 int []arr;
 int []arrr;

int i,n,k;

Console.WriteLine("Enter the size of array");
n= int.Parse(Console.ReadLine());
arr= new int[n];

Console.WriteLine("Enter the array elements for 1 array");
 for(i=0; i<n; i++)
{
arr[i] = int.Parse(Console.ReadLine());
}

arrr = new int[n];
Console.WriteLine("Enter the array elements for 2 array");
 for(i=0; i<n; i++)
{
arrr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("The array elements for both array are");
 for(i=0; i<n; i++)
{
Console.Write( arr[i] + " ");
Console.WriteLine(" ");
Console.Write( arrr[i] + " ");
}
int j=n;
int []sum;
sum= new int[n];
n--;
Console.WriteLine(n);
for(i=0;i<n; i++)
{
 sum[i]= arr[i] + arrr[n-i];
Console.WriteLine(sum[i]);

}

}}