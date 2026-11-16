using System;

class Prog
{
 int[][] arr;
 int n,c;
public void In( )
{
int i,j;
Console.WriteLine("Enter the number os rows");
i=int.Parse(Console.ReadLine());
arr= new int[i][];

for(n=0;n<arr.Length;n++)
{
Console.WriteLine("E
nter the number of ele");
j=int.Parse(Console.ReadLine());
arr[n] = new int[j];
for(c=0;c<arr[n].Length;c++)
{
Console.WriteLine("Enter the ele");
arr[n][c]=int.Parse(Console.ReadLine());
}
}
}
int p=0;
public void output()
{
for(n=0;n<arr.Length;n++)
{
for(c=0;c<arr[n].Length;c++)
{
p=arr[n][c]+p;
}
}
Console.WriteLine("The sum is" + p);
}

static void Main()
{

Prog pr = new Prog();

pr.In();
pr.output();
}
}







