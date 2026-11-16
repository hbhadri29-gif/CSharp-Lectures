using System;

class twsp
{
 static void  Main()
{

int [,]arr;

int i,j,c,r;

Console.WriteLine("Enter the number of  rows");
r=int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of  coulumns");
c=int.Parse(Console.ReadLine());
arr=new int[r,c];

for(i=0;i<r;i++)
{
Console.WriteLine("Enter the element in" + i );
for(j=0;j<c;j++)
{
arr[i,j]=int.Parse(Console.ReadLine());

}
}
Console.WriteLine("The printed array is");
for(i=0;i<r;i++)
{
for(j=0;j<c;j++)
{
Console.Write
(arr[i,j]);
}
Console.WriteLine(" ");
}
Console.WriteLine("The spiral is");
for(i=0;i<r;i++)
{
for(j=0;j<c;j++)
{

Console.WriteLine(arr[i,j]);
j=j+(n-1);
}

}
}
}