using System;

class twdiao

{
static void Main()
{

 int [,]arr;

int i,j,r,c;

Console.WriteLine("Enter the number of rows");
r= int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of columns");
c= int.Parse(Console.ReadLine());

arr= new int[r,c];

for(i=0;i<r;i++)
{
Console.WriteLine("Enter the rows ele" + i);
for(j=0;j<c;j++)
{
arr[i,j]=int.Parse(Console.ReadLine());
}
}

for(i=0;i<r;i++)
{
for(j=0;j<c;j++)
{
Console.Write(arr[i,j] + " ");
}
Console.WriteLine("");
}
int m=0;
int sum=0;
for(i=0;i<r;i++)
{
for(j=0;j<c;j++)
{


}
Console.WriteLine(arr[i,0+m]);
sum=arr[i,0+m]+sum;
m=m+1;

}
Console.WriteLine("The sum of diaognal " + sum);
int t=0;
int su=0;
for(i=r-1;i>=0;i--)
{
for(j=c-1;j>=0;j--)
{


}
Console.WriteLine(" ");
Console.WriteLine("The diagnoal is " + arr[i,t]);
su=arr[i,t]+su;
t=t+1;
}
Console.WriteLine(su);
}
}


