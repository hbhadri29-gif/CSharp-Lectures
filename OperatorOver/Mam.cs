using System;

class Mam
{

 public int Value;

public Mam(int v)
{

Value=v;
}


public static Mam operator-(Mam m1,Mam m2)
{


if(m1.Value-m2.Value<0)
{

return new Mam(-(m1.Value-m2.Value));

}

else

return new Mam(m1.Value-m2.Value);

}

static void Main()
{
Console.WriteLine("Enter the values");
int a=int.Parse(Console.ReadLine());
int b=int.Parse(Console.ReadLine());
Mam m4= new Mam(a);
Mam m5= new Mam(b);

Mam m7= m4-m5;



Console.WriteLine(m7.Value);


}
}
