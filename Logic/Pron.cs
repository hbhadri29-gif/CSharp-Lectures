using System;

class Pron

{

static void Main()
{
Console.WriteLine("Enter the number");
int n= Convert.ToInt32(Console.ReadLine());

int i;
  

for(i=1; i<=n; i++)

{
if(i*(i+1)==n)
{
Console.WriteLine("Number is Pronic");
break;
}



}

}
}