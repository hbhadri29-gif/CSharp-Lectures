using System;

class large

{
 static void Main()
{
 int []arr;
 int i,n,j;

Console.Write("Enter the size of array");
n= int.Parse(Console.ReadLine());

arr = new int[n];

for(i=0;i<n;i++)
{

Console.Write("Enter the array elements");
arr[i] = int.Parse(Console.ReadLine());
}


for(i=0;i<n;i++)
{
Console.Write(arr[i] + " ");

}

j=arr[0];

for(i=1;i<n;i++)
{
if(arr[i]>=j)
j=arr[i];
}
Console.WriteLine("the largest ele is" + j);
}
}