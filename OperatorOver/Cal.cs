using System;

class Calculator
{

public int Value;

public Calculator(int value)
{

Value=value;
}

public static Calculator Add(Calculator a, Calculator b)
{

return new Calculator(a.Value+ b.Value);
}
public static Calculator operator +(Calculator a,Calculator b)
{
return Add(a,b);

}

static void Main()
{
Console.WriteLine("Enter the values");
int c= int.Parse(Console.ReadLine());
int d= int.Parse(Console.ReadLine());
Calculator s = new Calculator(c);
Calculator s2 = new Calculator(d);
Calculator rs1= s+s2;
Calculator rs2 = Calculator.Add(s,s2);
Console.WriteLine(rs2.Value);


}
}