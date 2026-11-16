using System;

class spy

{

static void Main()

{

Console.WriteLine("Enter the number");
 int n= Convert.ToInt32(Console.ReadLine());

int rem,s=0,p=1;

while(n>0)

{

rem=n%10;
s=s+rem;
p=p*rem;
n=n/10;
}
Console.WriteLine(p);
Console.WriteLine(s);
if(p==s)
{
Console.WriteLine("Number is spy");
}

else
{
Console.WriteLine("Number is not spy");

}
}
}