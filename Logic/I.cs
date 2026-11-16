using System;

class Reverse
{

static void Main()
{


Console.WriteLine("Enter the Reverse number");
int num=Convert.Parse(Console.ReadLine());
int rem;
while(num>0)
{

rem=num%10;
Console.Write(rem);
num=num/10;

}
}
}