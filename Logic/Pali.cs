using System;

class Pali

{
 static void Main()

{
 
Console.WriteLine("Enter the number");
int  n = Convert.ToInt32(Console.ReadLine());
int i=0,a=n;
int r,s=0;
 while(n>0)
{

 r=n%10;
 s=(s*10)+r;


 n=n/10;
 
}

Console.WriteLine(s);
if(a==s)
{
Console.WriteLine("Plaindrome Number");
}

else
{
Console.WriteLine("Not a plaindrome number");
}
}
}

