using System;

class Com

{

int value;

public Com(int val)
{
value=val;
}

public static bool operator <(Com a,Com b)
{

return a.value<b.value;

}

public static bool operator >(Com a,Com b)
{


return a.value>b.value;




}
static void Main()
{

int c= int.Parse(Console.ReadLine());
int d= int.Parse(Console.ReadLine());
Com c1= new Com(c);
Com c2=new Com(d);
Com c5= new Com(c);
Com c6=new Com(d);
bool c3=c1<c2;
bool c4=c5>c6;
Console.WriteLine(c3);
Console.WriteLine(c4);
}
}