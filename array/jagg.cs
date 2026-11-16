using System;

class jagg
{
static void Main()
{

int[][] arr;

int i,j,r;

Console.WriteLine("Enter the no of rows");
r= int.Parse(Console.ReadLine());
arr= new int[r][];


for(i=0; i<arr.Length; i++)
{

Console.WriteLine("Enter the number of cele for rows");

int c= int.Parse(Console.ReadLine());

arr[i] = new int[c];

for(j=0;j<arr[i].Length;j++)
{

Console.WriteLine("Enter the number os ele");
arr[i][j]=int.Parse(Console.ReadLine());
}
}

for(i=0;i<  arr.Length;i++)
{
  for(j=0;j<arr[i].Length;j++)
{
Console.Write( arr[i][j] + " ");
}

Console.WriteLine(" ");
}

}
}