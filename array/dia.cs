using System;

class dia
{

static void Main()
{
 int [,]arr;

int i,j,r,c;

Console.WriteLine("Rows");
r=int.Parse(Console.ReadLine());

Console.WriteLine("Columns");
c=int.Parse(Console.ReadLine());
int k=0;
arr = new int[r,c];

for(i=0;i<r;i++)
{
for(j=0;j<c;j++)
{
  if(arr[i,k]==arr[i,j])
{
  arr[i,k]=0;
 
}

else
{
 arr[i,k]=1;
}

}
k=k+1;
}

for(i=0;i<r;i++)
{
for(j=0;j<c;j++)
{
Console.Write(arr[i,j] + " ");
}
Console.WriteLine(" ");
}
}
}