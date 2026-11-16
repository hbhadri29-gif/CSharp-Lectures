using System;

class lead
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        int esum = 0;
        int osum = 0;
        int temp = n;

        while (temp > 0)
        {
            int digit = temp % 10;

            if (digit % 2 == 0)
                esum += digit;
            else
                osum += digit;

            temp = temp / 10;
        }

        if (esum == osum)
            Console.WriteLine(n+ " is a Lead Number");
        else
            Console.WriteLine(n+ " is not a Lead Number");
    }
}
