using System;

class arm

{
static void Main()
{
Console.WriteLine("Enter the number");
int n= Convert.ToInt32(Console.ReadLine());

int a=0;
int r;
int x=n;
int s=0;
while(n>0)

{

r=n%10;
a=r*r*r;
s=s+a;
n=(int)n/10;
}
if(s==x)
{
Console.WriteLine("Number is armstrong");

}

else
{
Console.WriteLine("Number is not armstrong");
}
}}
