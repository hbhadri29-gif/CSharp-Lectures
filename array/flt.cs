using System;


class flt

{

static void Main()
{

float []arr;

int i,n;
float k;

Console.WriteLine("Enter the size of array elements");

n = int.Parse(Console.ReadLine());
arr = new float[n];
Console.WriteLine("Enter the array elements");

for(i=0; i<n;i++)
{
arr[i] = float.Parse(Console.ReadLine());
}



for(i=0; i<n;i++)
{
Console.WriteLine(" the array elements are" + arr[i]);
}
float j;
j=arr[0];
for(i=0; i<n;i++)
{
 if(j>=arr[i])
{
j=arr[i];
}
}
Console.WriteLine("The smallest element is " + j);

k=arr[0];
for(i=0; i<n;i++)
{
 if(k<=arr[i])
{
k=arr[i];
}
}
int z=0;
Console.WriteLine("The largest element is " + k);
for(i=0;i<n;i++)
{
if(arr[i]<0)
{
z=z+1;
}
}
Console.WriteLine("The negative element are " + z);
int x=0;
for(i=0;i<n;i++)
{
if(arr[i]>0 && arr[i]%2==0)
{
x=x+1;
}
}
Console.WriteLine("The postive elements are " + x);
int y=0;
for(i=0;i<n;i++)
{
if(arr[i]<0 && arr[i]%2!=0)
{
y=y+1;
}
}
Console.WriteLine("The negative elements are " + y);
float []arrr;
float c=0;
for(i=0;i<n;i++)
{
c=arr[i]+c;
}
Console.WriteLine("The sum of elements is" + c);

}
}