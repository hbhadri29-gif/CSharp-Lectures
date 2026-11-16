using System;

class twsu

{
static void Main()
{


int [,]arr;

int i,j,r,c;

Console.WriteLine("Enter the number of rows in array");
r= int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of coulumns in array");
c= int.Parse(Console.ReadLine());
arr= new int[r,c];

for(i=0;i<r;i++)
{
Console.WriteLine("Enter the element in row");
for(j=0;j<c;j++)
{
arr[i,j]= int.Parse(Console.ReadLine());
}
}
int [,]arrr;

arrr=new int[c,r];

for(i=0;i<r;i++)
{

for(j=0;j<c;j++)
{
Console.Write(arr[i,j] + " ");
arrr[j,i]=arr[i,j];
}
Console.WriteLine(" ");
}
int sum=0;



Console.WriteLine("The transporsal of arraY");
for(j=0;j<c;j++)
{
for(i=0;i<r;i++)
{
Console.Write(arrr[j,i] + " " );
}

Console.WriteLine(" ");
}
}
}
