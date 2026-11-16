using System;

class arr
{
 static void Main()
{

int arr[];
int i,n;
Console.WriteLine("Enter the size of array");
arr= new int[n];

for(i=0;i<n;i++)
{
Console.WriteLine("Enter the elements");
arr[i]=int.Parse(Console.ReadLine());
}

for(i=0;i<n;i++)
{
Console.WriteLine(arr[i] + " ");
}

}
}