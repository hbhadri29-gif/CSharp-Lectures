using System;

class fact
{

static void Main()
{
try{
 int i,s,f=1;

Console.WriteLine("ENter the number");

i=Convert.ToInt32(Console.ReadLine());

for(s=1;s<=i;s++)
{
 f=f*s;
}

Console.WriteLine("the factorial is" + f);
}
catch(System.OverflowException se){
Console.WriteLine("too long integer" + se.Message);

}
}
}
