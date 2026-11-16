using System;

class ar
{
 static void Main()
{
int []arr;
int n,i;

Console.WriteLine("enter the number of elements");
n= int.Parse(Console.ReadLine());

arr= new int[n];

Console.WriteLine("Enter the ele in array");
for(i=0;i<n;i++)
{

arr[i] = int.Parse(Console.ReadLine());

}


for(i=0;i<n;i++)
{
Console.WriteLine(arr[i] + " ");

}

int j=0,k=0;


for(i=0;i<n;i++)
{

if(arr[i]%2==0)
{
j=j+1;
} 

else
{
k=k+1;
}

}
Console.WriteLine(" The even value are" + j);
Console.WriteLine(" The odd value are" + k);
}
}