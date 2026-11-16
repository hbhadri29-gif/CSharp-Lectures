using System;

class Fraction
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;

        // Reduce fraction
        int a = Math.Abs(Numerator);
        int b = Math.Abs(Denominator);

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        Numerator = Numerator / a;
        Denominator = Denominator / a;
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        return new Fraction(
            a.Numerator * b.Denominator + b.Numerator * a.Denominator,
            a.Denominator * b.Denominator
        );
    }

    public static Fraction operator -(Fraction a, Fraction b)
    {
        return new Fraction(
            a.Numerator * b.Denominator - b.Numerator * a.Denominator,
            a.Denominator * b.Denominator
        );
    }

    public static Fraction operator *(Fraction a, Fraction b)
    {
        return new Fraction(
            a.Numerator * b.Numerator,
            a.Denominator * b.Denominator
        );
    }

    public static Fraction operator /(Fraction a, Fraction b)
    {
        return new Fraction(
            a.Numerator * b.Denominator,
            a.Denominator * b.Numerator
        );
    }

    public override string ToString()
    { 
        return Numerator + "/" + Denominator;
    }
}

class Program
{
    static void Main()
    {
        Fraction f1 = new Fraction(2, 4);
        Fraction f2 = new Fraction(1, 2);

        Console.WriteLine("Addition: " + (f1 + f2));
        Console.WriteLine("Subtraction: " + (f1 - f2));
        Console.WriteLine("Multiplication: " + (f1 * f2));
        Console.WriteLine("Division: " + (f1 / f2));
    }
}