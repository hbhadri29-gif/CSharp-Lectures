using System;

class sym
{

static void Main()
{

int [,]arr;

int i,j,r,c;
int k=0;
Console.WriteLine("Enter the number os rows in array");

r=int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of columns");

c= int.Parse(Console.ReadLine());

arr= new int[r,c];

int [,]arrr;

arrr = new int[c,r];


for(i=0;i<r;i++)
{
Console.WriteLine("Enter the elements of array");
for(j=0;j<c;j++)
{
arr[i,j]=int.Parse(Console.ReadLine());
arrr[j,i]=arr[i,j];
k=k+1;
}
}

Console.WriteLine("The array is ");
for(i=0;i<r;i++)
{
for(j=0;j<c;j++)
{
Console.Write(arr[i,j] + " ");
}
Console.WriteLine(" ");
}

Console.WriteLine("The transporasl of array is ");

for(i=0;i<c;i++)
{
for(j=0;j<r;j++)
{
Console.Write(arrr[i,j] +" ");
}
Console.WriteLine(" ");
}
int t=0;
if(r!=c)
{
Console.WriteLine("Not sy");
}
else
{

for(i=0;i<r;i++)
{
for(j=0;j<c;j++)
{
if(arr[i,j]==arr[j,i])
{
 t=t+1;
}

}
}
if(t==k)
{Console.WriteLine("The array is sy");
}

else
{
Console.WriteLine("The elements are not matching so  thats whyits non sym");
}
}


}
}

