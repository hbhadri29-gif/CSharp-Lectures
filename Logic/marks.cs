using System;

class marks

{
static void Main()

{

string ch ="Y";
while( ch=="Y" || ch== "y")
{
Console.WriteLine("Enter the marks of 4 subj");
float m1=int.Parse(Console.ReadLine());
float m2=int.Parse(Console.ReadLine());
float m3=int.Parse(Console.ReadLine());
float m4=int.Parse(Console.ReadLine());
float avg;
avg=(m1+m2+m3+m4)/4.0f;
Console.WriteLine(avg);
Console.WriteLine("Want to contiune yes/no");
ch=Console.ReadLine();
}
}
}
