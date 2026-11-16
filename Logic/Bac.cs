using System;

class Bac

{

static void Main()
{
double weight,amt,tim,bac;
string gender;

Console.WriteLine("Enter the Gender");
gender= Console.ReadLine();

Console.WriteLine("Enter the Weight");
weight=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the Amount Of alochol");2222
amt=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the time you drink the alochol last time");
tim = Convert.ToDouble(Console.ReadLine());

if(gender=="male")
{
 
bac = (amt*5.14/weight*0.73)-0.15*tim;
Console.WriteLine("Your bac is " + bac);

}

else if(gender=="female")
{
 
bac =(amt*5.14/weight*0.66)-0.15*tim;
Console.WriteLine("Your bac is " + bac);

}


}
}

  