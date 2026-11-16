using System;

class Pro

{

int Value;

public Pro(int val)
{

Value = val;

}

public static bool operator ==(Pro p1, Pro p2)
{

return p1.Value == p2.Value;

}
public static bool operator !=(Pro p1, Pro p2)
{

return p1.Value != p2.Value;

}


static void Main()
{

Console.WriteLine("Enter the number");
int a=int.Parse(Console.ReadLine());
int b=int.Parse(Console.ReadLine());

Pro c = new Pro(a);
Pro d= new Pro(b);
Pro g= new Pro(a);
Pro f= new Pro(b);
bool k = c==d;
bool l = g!=f;
Console.WriteLine(k);
Console.WriteLine(l);
}
}
