using System;

class sarry

{
static void Main()
{

int []arr;
int []arrr;
int sum;
int []ary;
int n,i,j,k;

Console.WriteLine("Enter the size of first array");
n=int.Parse(Console.ReadLine());
arr = new int[n];
Console.WriteLine("Enter the first array elements array");
for(i=0; i<n;i++)
{
arr[i]=int.Parse(Console.ReadLine());
}


Console.WriteLine("Enter the size of second array");
j=int.Parse(Console.ReadLine());
arrr = new int[j];
Console.WriteLine("Enter the second array elements array");
for(i=0; i<j;i++)
{
arrr[i]=int.Parse(Console.ReadLine());
}

for(i=0;i<n;i++)
{
Console.WriteLine("The first array elements are" + arr[i]); 
Console.WriteLine("The second array elements are" + arrr[i]);
 }
ary =new int[n];
for(k=0;k<n; k++)
{
sum=arr[k]+arrr[k];

ary[k]=sum;
Console.Write(ary[k] + " ");
}

}
}