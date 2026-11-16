using System;

class dis

{

  static void Main()

{
 Console.WriteLine("Enter the number");


int n = Convert.ToInt32(Console.ReadLine());
 int i,rem,x=0,s=0,p=1,t=n;

if(n>99 && n<1000)
{
x=3;
}
while(n>0)

{


rem=n%10;
for(i=1; i<=x;i++)
{
p=p*rem;
}
Console.WriteLine(p);
s=s+p;
x=x-1;

p=1;
n=n/10;
Console.WriteLine(rem);
}

if(s==t)

{

Console.WriteLine("Number is disarium");
}
else
{
Console.WriteLine("no its not");

}
}
}


