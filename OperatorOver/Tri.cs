using System;

class Tri
{
double Height,Base,outt;

public Tri(double height,double bas)
{
Height = height;
Base= bas;
}

public static Tri operator *( Tri t1, double n)
{
return new Tri(t1.Height,t1.Base*n);

}

public void Display()
{
outt=Height*Base;
Console.WriteLine("The Result is "+ outt );
}

static void Main()
{
 Tri tt1= new Tri(2,3);
 Tri tt2= tt1 * 0.5;
tt2.Display();
}
}

