using System;

class two
{
static void Main()
{
int [,]arr;

int k,i,j,r,c;

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
int p=r*c;
int []arrr;
arrr= new int[p];
int sum=0;
for(i=0;i<r;i++)
{


for(j=0;j<c;j++)
{
sum=arr[i,j]+sum;

for(k=0;k<p;k++)
{
arrr[k]=sum;
}
sum=0;
}
}
for(k=0;k<p;k++)
{
Console.Write(arrr[k]);

}
}
}

