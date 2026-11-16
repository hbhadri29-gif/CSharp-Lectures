using System;

class ter
{
static void Main()
{
int [,]arr;

int k=0,i,j,r,c;

Console.WriteLine("Enter  the the number of rows");
r= int.Parse(Console.ReadLine());
Console.WriteLine("enter the number of rcolumns");
c=int.Parse(Console.ReadLine());
arr= new int[r,c];
for(i=0;i<r;i++)
{
Console.WriteLine("ENetr the elements" + i);
for(j=0;j<c;j++)
{
arr[i,j]= int.Parse(Console.ReadLine());
}
}
int []arrr;
int p=r*c;

arrr= new int[p];
int sum=0;
for(i=0;i<r;i++)
{


for(j=0;j<c;j++)
{
sum=arr[i,j]+sum;


arrr[k]=sum;
k=k+1;
sum=0;
}
}
for(k=0;k<p;k++)
{
Console.Write(arrr[k]);

}
}
}

