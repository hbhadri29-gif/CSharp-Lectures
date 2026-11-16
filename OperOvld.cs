using System;
class OperOvld
{
    private int x;
    private int y;
    public OperOvld()
    {
    }
    public OperOvld(int i, int j)
    {
        x = i;
        y = j;
    }
    public void ShowXY()
    {
        Console.WriteLine("{0} {1}", x, y);
    }
    public static OperOvld operator -(OperOvld c)
    {
        OperOvld temp = new OperOvld();
        temp.x = -c.x;
        temp.y = -c.y;
        return temp;
    }
}
class MyClient
{
    public static void Main()
    {
        OperOvld c1 = new OperOvld(10, 20);
        c1.ShowXY(); 
        OperOvld c2 = new OperOvld();
        c2.ShowXY(); 
        c2 = -c1;
        c2.ShowXY(); 
    }
}