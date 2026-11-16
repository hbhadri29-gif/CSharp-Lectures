using System;

class twpime
{

static void Main()
{

int [,]arr;

int i,j,r,c;

Console.WriteLine("Enter the number of rows");
r= int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of columns");
c=int.Parse(Console.ReadLine());

arr= new int[r,c];
int t=0;
for(i=0;i<r;i++)
{

Console.WriteLine("Enter the array elements" + (t+1));
for(j=0;j<c;j++)
{
arr[i,j]= int.Parse(Console.ReadLine());
}
}

Console.WriteLine(" the array elements are");

for(i=0;i<r;i++)
{
for(j=0;j<c;j++)
{
Console.WriteLine(arr[i,j]);
}}
int k,m=0,n=0;

for(i=0;i<r;i++)
{
for(j=0;j<c;j++)
{
for(k=1;k<=arr[i,j];k++)
{
Console.Write(k);
if(arr[i,j]%k==0)
{

m=m+1;

}
}
if(m==2 )
{
n=n+1;
}
m=0;


}}
Console.WriteLine("the prime ele are" + n);
}
}

