using System;

class Fact
{

int i,f;

Fact(int num)
{
f=1;
 for(i=1;i<=num;i++)
{
f=i*f;

}
}
Fact(Fact hh)
{
f=hh.f;

}
static void Main()
{
 Fact f1= new Fact(5);
 Console.WriteLine(f1.f);
Fact f2= new Fact(f1);
 Console.WriteLine(f2.f);


}
}