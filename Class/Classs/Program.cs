using System;

class Program
{
    int r;
    void ReverseNum()
    {
        int num = 0;
        Console.WriteLine("Enter a number ");
        num = int.Parse(Console.ReadLine());
        while (num > 0)
        {
            r = num % 10;
            Console.Write(r);
            num = num / 10;
        }

    }
    void FindDuck(int num1)
    {
        int m = num1, n = 0;
        while (num1 > 0)
        {
            r = num1 % 10;
            if (r == 0)
            {
                Console.WriteLine("Duck number " + m);
                n = 1;
                break;

            }
            num1 = num1 / 10;

        }
        if (n == 0)
            Console.WriteLine("Not a duck number " + m);
    }


    static void Main()
    {
       
            Program dm = new Program();
        try
        {
            Console.WriteLine("Which program you want to call 1 or 2");
        int value = int.Parse(Console.ReadLine());
        
            switch (value)
            {
                case 1:
                    {
                        dm.ReverseNum();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("ENter the number");
                        int b = int.Parse(Console.ReadLine());
                        dm.FindDuck(b);
                        break;
                    }
                default:
                    Console.WriteLine("Out of bound");
                    break;
            }
        }
        catch(System.FormatException fe)
        {
            Console.WriteLine("Error !" + fe.Message);
        }
        }

}