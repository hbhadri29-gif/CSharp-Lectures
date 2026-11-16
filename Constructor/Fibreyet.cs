using System;

class Fibrebyte
{
 int agee;
int rsgg;
double thrp=0.75;
int max=200;
int rhr=50;
double thr;
public Fibrebyte(int age, int rshh)
{

agee=age;
rhr=rshh;
}

public double Fit()
{

thr = ((max-rhr)*thrp+rhr);
Console.WriteLine(thr);
return thr;

}
static void Main()
{

Fibrebyte rs = new Fibrebyte(20,60);
Console.WriteLine(rs.Fit());

}
}
