using System;

class twsum

{

static void Main()
{
 int [,]arr;

int i,j,r,c;

Console.WriteLine("Enter the number of rows");

r= int.Parse(Console.ReadLine());

Console.WriteLine("Enter  the number of columns ");

c= int.Parse(Console.ReadLine());

arr = new int[r,c];

for(i=0;i<r;i++)
{
Console.WriteLine("Enter the array in " + i + "row");
for(j=0;j<c;j++)
{
arr[i,j]=int.Parse(Console.ReadLine());
}
}


for(i=0;i<r;i++)
{

for(j=0;j<c;j++)
{
Console.Write( arr[i,j]+ " ");
}
Console.WriteLine("");
}

int sum=0;
for(i=0;i<r;i++)
{
for(j=0;j<c;j++)
{
sum=arr[i,j]+sum;


}
Console.WriteLine("The sum  of " + i + " is " +sum);
sum=0;
}
}
}