using System;

class po
{
static void Main()
{

int[][] arr;

int i,j,r,c;

Console.WriteLine("Row");
r=int.Parse(Console.ReadLine());

arr= new int[r][];

for(i=0;i<arr.Length;i++)
{
 Console.WriteLine("ele in row");
c=int.Parse(Console.ReadLine());
 arr[i] = new int[c];
for(j=0;j<arr[i].Length;j++)
{
arr[i][j]=int.Parse(Console.ReadLine());

}
}

int k=0;
int l=0;
for(i=0;i<arr.Length;i++)
{
 
for(j=0;j<arr[i].Length;j++)
{
l=arr[i][j]+l;

k=arr[i][j]+k;
}
Console.WriteLine("The sum of row is " + l);
l=0;
}
Console.WriteLine(k);
}
}