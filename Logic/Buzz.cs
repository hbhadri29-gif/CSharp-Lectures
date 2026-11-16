using System;

class Buzz

{
 static void Main()

{

Console.WriteLine("Enter the number");
int n=Convert.ToInt32(Console.ReadLine());



if(n%10==7 || n%10==0)
{
Console.WriteLine("Number is buzz");
}

else 

{
Console.WriteLine("Number is not buzz");
}

}
}