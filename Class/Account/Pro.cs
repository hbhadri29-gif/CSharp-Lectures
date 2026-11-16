using System;

class Pro
{
    int no;
    public void Prime()
    {
        Console.WriteLine("Enter the numberr");
        no = int.Parse(Console.ReadLine());
        int j, k = 0;
        for (int i = 1; i <= no; i++)
        {
            if (no % i == 0)
            {
                k = k + 1;
            }

        }
        if (k == 2)
        {
            Console.WriteLine("Number is prime");
        }

        else
        {
            Console.WriteLine("Na its not");
        }
    }
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
  
}