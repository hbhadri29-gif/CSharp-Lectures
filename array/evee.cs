using System;

class evee
{
static void Main()
{
int []arr;
char []arrr;

char e,o;
int n,i;
Console.WriteLine("Enter the size of array");

n= int.Parse(Console.ReadLine());
arr = new int[n];
Console.WriteLine("Enter the ele");
for(i=0; i<n;i++)
{
arr[i]=int.Parse(Console.ReadLine());

}

Console.WriteLine("The array ele are");

for(i=0; i<n;i++)
{
Console.WriteLine(arr[i] + " ");
}

arrr =new char[n];
for(i=0; i<n;i++)
{
  if(arr[i]%2==0)
{
arrr[i] = 'e';
}
 else
{
arrr[i] = 'o';
}

Console.Write(arrr[i] + " ");

}

}
}
