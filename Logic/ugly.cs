using System;

class ugly
{
static void Main()

{
Console.WriteLine("Enter the Number");
int n= Convert.ToInt32(Console.ReadLine());
int i=1;
int j;
while(n%2==0)
{
n=n/2;
}

while(n%3==0)
{
n=n/3;
}

while(n%5==0)
{
n=n/5;
}

if(n==1)
{
Console.WriteLine("number is ugly");

}

else
{
Console.WriteLine("number is not");
}





}
}

