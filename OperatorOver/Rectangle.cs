using System;

class Rectangle
{
    public int Length;
    public int Width;

    public Rectangle(int length, int width)
    {
        Length = length;
        Width = width;
    }

    public static Rectangle operator *(Rectangle r, int n)
    {
        return new Rectangle(r.Length * n, r.Width * n);
    }

    public void Display()
    {
        Console.WriteLine($"Length = {Length}, Width = {Width}");
    }
}

class Program
{
    static void Main()
    {
        Rectangle r1 = new Rectangle(5, 4);
        Rectangle r2 = r1 * 2;
        r2.Display();
    }
}