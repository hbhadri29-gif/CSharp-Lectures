using System;

class strong

{

 static void Main()

{
Console.WriteLine("Enter the Number");
 int n=Convert.ToInt32(Console.ReadLine());
int f=1;
 int r;
int s=0;
int i;
int a=n;
while(n>0)
{
 r=n%10;
for(i=1;i<=r;i++)
 f=f*i;
 s=s+f;
 n=n/10;
 f=1;
}

if(s==a)
{
Console.WriteLine("Nmber is strong");

}

else
{
Console.WriteLine("Number is not strong");
}
}
}
