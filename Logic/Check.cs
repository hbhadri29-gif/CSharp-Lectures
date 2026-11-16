using System;

class Check
{
static void Main()
{

double a,b,c,s,f;
double t;
a= 100;
b=60;
c=90;
Console.WriteLine("Price for Mango is" + a);

Console.WriteLine("Price for Apple is " + b);
Console.WriteLine("Price for Kiwi is " + c);
s= a+b+c;
Console.WriteLine("Subtotal is " + s);

t =(5.5/100)*s;

Console.WriteLine("tax is " + t);
f=t+s;
Console.WriteLine("Final price is" + f);

}} 


