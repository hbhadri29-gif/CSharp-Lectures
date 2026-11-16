using System;

class mat
{
static void Main()
{
int [,]arrr;
int [,]arr;
int i,j,r,c;

Console.WriteLine("rows");
r= int.Parse(Console.ReadLine());
Console.WriteLine("col");
c= int.Parse(Console.ReadLine());
arr= new int[r,c];
Console.WriteLine("arrray ele");
for(i=0;i<r;i++)
{
Console.WriteLine("Enter array ele" );
for(j=0;j<c;j++)
{
arr[i,j]= int.Parse(Console.ReadLine());
}
}
arrr= new int[r,c];
Console.WriteLine("2 arrray ele");
for(i=0;i<r;i++)
{
Console.WriteLine("Enter array ele" );
for(j=0;j<c;j++)
{
arrr[i,j]= int.Parse(Console.ReadLine());
}
}

Console.WriteLine("The array element of 1 array");
for(i=0;i<r;i++)
{for(j=0;j<c;j++)
{
Console.Write(arr[i,j] + " ");
}
Console.WriteLine(" ");
}

Console.WriteLine("The array element of 1 array");
for(i=0;i<r;i++)
{for(j=0;j<c;j++)
{
Console.Write(arrr[i,j] + " ");
}
Console.WriteLine(" ");
}
int [,]result;
int k;
result =new int[r,c];

for(i=0;i<r;i++)
{
 for(j=0;j<c;j++)

{
result[i,j]=0;
for(k=0;k<c;k++)
{

result[i,j]=result[i,j]+arr[i,k]*arrr[k,j];

}
}
}
Console.WriteLine("The matrix element are");
for(i=0;i<r;i++)
{
for(j=0;j<c;j++)
{
Console.Write(result[i,j] + " ");
}
Console.WriteLine(" ");
}
}
}
