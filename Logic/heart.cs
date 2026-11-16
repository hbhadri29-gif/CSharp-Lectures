using System;

class heart

{
static void Main()
{

int a,h,i,k;

Console.WriteLine("Enter the age");
a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the heart rate");
h=Convert.ToInt32(Console.ReadLine());

for(i=55; i<=95; i++)
{
k=(((220-a)-h)*i)+h;
Console.WriteLine(  k);
}

}
}

