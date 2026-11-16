using System;

class more

{

 static void Main()
{
 int []arr;
int []arrr;
int i,n,k;
Console.WriteLine("Enter the size of array");
n= int.Parse(Console.ReadLine());

arr = new int[n];
arrr = new int[n];
Console.WriteLine("Enter the 1 array ele");
for(i=0;i<n;i++)
{
arr[i]=int.Parse(Console.ReadLine());
}

Console.WriteLine("Enter the 2 array ele");
for(i=0;i<n;i++)
{
arrr[i]=int.Parse(Console.ReadLine());
}

Console.WriteLine("The 1  array ele are ");
for(i=0;i<n;i++)
{

Console.WriteLine(arr[i]);
}


Console.WriteLine("The 2 array ele are ");
for(i=0;i<n;i++)
{

Console.WriteLine(arrr[i]);
}

k=n*2;
int j=k/2;

int []ar;
ar = new int[k];

for(i=0;i<j;i++)
{
ar[i]=arr[i];



}

int p=0;
for(i=j;i<k;i++)
{
ar[i]=arrr[p];
p=p+1;

}

for(i=0;i<k;i++)
{

Console.WriteLine(ar[i]);
}


}
}

