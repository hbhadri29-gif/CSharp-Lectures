using System;

class spe


{

 static void Main()
{

Console.WriteLine("Enter a number");

int n=Convert.ToInt32(Console.ReadLine());
int a=n;
int rem, pro=1,sum=0,f=0;
while(n>0)
{
rem=n%10;
sum=sum+rem;
pro=pro*rem;
f=sum+pro;
n=n/10;
}
Console.WriteLine(f);

if(a==f)
{
Console.WriteLine("number is special");
}
else
{
Console.WriteLine("not special");
}
}
}