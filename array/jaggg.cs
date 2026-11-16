using System;

class jagg
{
static void Main()
{

int [][] arr;

int i,j,r,c;

Console.WriteLine("Enter the no of rows");
r= int.Parse(Console.ReadLine());



for(i=1; i<arr.length; i++)
{

Console.WriteLine("Enter the number of cele for rows");

c= int.Parse(Console.Readline());

jag[i] = new int[c];

for(j=0;j<c;j++)
{

Console.WriteLine("Enter the number os ele");
arr[i][j]=int.Parse(Console.ReadLine());
}
}

for(i=0;i<r;i++)
{
  for(j=0;j<c;j++)
{
Console.WriteLine( arr[i][j] + " ");
}
}
