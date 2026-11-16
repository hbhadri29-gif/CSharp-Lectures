using System;

class Him
{

static void Main()
{
int []arr=new int[5]{1,2,4,5,6};
int i,k=0,c=0;
Console.WriteLine("Enter the numbers");

int n=int.Parse(Console.ReadLine());
int g=0;
for(i=1;i<n;i++)
{
k=k+i;
}

int j=1;
for(i=0;i<5;i++)
{

c=arr[i]+c;
}
if(k!=c)
{
g=c-k;
}
Console.WriteLine(g);

}
}