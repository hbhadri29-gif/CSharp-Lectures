using System;

class ja
{
static void Main()
{
 int[][] arr;

 int i,j,r,c;

Console.WriteLine("enter row");

r= int.Parse(Console.ReadLine());

arr = new int[r][];

foreach(int[] row in arr[r])
{
Console.WriteLine("enter ele");
c= int.Parse(Console.ReadLine());
arr[r] = new int[c];
foreach(int[][] ele in row[r][c])
{
ele[r][c]=int.Parse(Console.ReadLine());
}
}

foreach(int []row in arr)
{

foreach(int[][] ele in row)
{
Console.WriteLine(ele[r][c] + " ");
}
Console.WriteLine();
}
}
}
