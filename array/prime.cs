using System;

class prime
{
static void Main()
{
int []arr;
 int i,n,j,num,c=0;

Console.WriteLine("Enter the size of array");
n= int.Parse(Console.ReadLine());
arr = new int[n];
Console.WriteLine("Enter the array elements");
for(i=0; i<n;)
{
c=0;
num=int.Parse(Console.ReadLine());
for(j=1;j<=num;j++)
{
 if(num%j==0)
{
c=c+1;
}}
if(c==2)
{
arr[i]=num;
i++;

Console.WriteLine("The array elements are " + arr[i] );
}




}

}
}
