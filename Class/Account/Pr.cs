using System;

class Pr
{

    int n;
    public void fact()
    {
        Console.WriteLine("Enter the number");
        n = int.Parse(Console.ReadLine());
        int f = 1;
        for (int i = 1; i <= n; i++)
        {
            f = f * i;

        }
        Console.WriteLine("The factorial is " + f);

    }
    public void fact(int n)
    {
        int f = 1;
        for(int i=1;i<=n;i++)
        {
            f = f * i;

        }
        Console.WriteLine("The factorial is " + f);

    }

}
