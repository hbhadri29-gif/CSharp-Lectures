using System;

class harsh
{

static void Main()

{

Console.WriteLine("Enter tthe number");

int n = Convert.ToInt32(Console.ReadLine());

int s=0;
int r;
int a=n;

while(n>0)
{

r=n%10;
s=s+r;
n=n/10;
}

if(a%s==0)
{
Console.WriteLine("Number is harshad");
}
else
{
Console.WriteLine("Number is not harshad");

}
}
}