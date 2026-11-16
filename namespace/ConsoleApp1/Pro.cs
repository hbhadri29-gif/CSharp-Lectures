using System;

class Pro
{
    public void Prime(int no)
    {
        int j,k = 0;
        for(int i = 1; i <= no; i++) 
        {
            if(no % i==0)
            {
                k = k + 1;
            }
        
        }
        if(k==2)
        {
            Console.WriteLine("Number is prime");
        }

        else
        {
            Console.WriteLine("Na its not");
        }
    }
   static void Main()
    {
        Pro pm = new Pro();
        Console.WriteLine("Enter the number");
        int n = int.Parse(Console.ReadLine());
        Pro.prime()
    }
}