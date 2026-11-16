using System;

class small
{

static void Main()
{
int []arr;
int i,j,n;
{
Console.WriteLine("Enter the size of array");
n= int.Parse(Console.ReadLine());
arr = new int[n];
 for (i=0; i<n;i++)
{Console.WriteLine("Enter  the ele");
 arr[i]=int.Parse(Console.ReadLine());   
}

for(i=0;i<n;i++)
{
Console.Write(arr[i] + " ");
}
j=arr[0];

for(i=0; i<n;i++)
{ if(arr[i]<=j) 

j=arr[i];  

}
Console.WriteLine(j);
}
}
}