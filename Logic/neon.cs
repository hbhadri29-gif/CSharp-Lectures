using System;


class neon


{

 static void Main()


{

 Console.WriteLine("Enter the number");

int n=Convert.ToInt32(Console.ReadLine());
int a=n;
int rem,f=1,s=0;
f=n*n;
while(f>0)
{

rem=f%10;

s=rem+s;

f=f/10;
}

if( a==s)
{

Console.WriteLine("Number is neon");

}

else 
{

Console.WriteLine("Number is not neon");

}


}}