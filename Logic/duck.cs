using System;

class duck
{

static void Main()
{

Console.WriteLine("Enter the number");
int n = Convert.ToInt32(Console.ReadLine());

int rem=0,x=0;

while(n>0)
{

if(rem==n%10)

{
x=1;
Console.WriteLine("duck number");
break;
}

n=n/10;

}

if(x==0)
{
Console.WriteLine("Number is not duck");

}
}
}


