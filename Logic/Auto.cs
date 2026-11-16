using System;

class Auto

{
 static void Main()
{

Console.WriteLine("Enter the number");

int n= Convert.ToInt32(Console.ReadLine());
 
int s;

s=n*n;

if(n%10 == s%10)
{
Console.WriteLine("Number is automorphic");
}

else
{
Console.WriteLine("Number is not");
}

}
}