using System;

class nm
{
static void Main()
{
try{
int number;

Console.WriteLine ("enter number");
number=int.Parse(Console.ReadLine());


Console.WriteLine(number);
}
catch(System.FormatException Fe)
{
Console.WriteLine("Put integer as input" + Fe.Message);
}
}
}
