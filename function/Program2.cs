using System;

class Program2
{
    static void Main()
    {
       
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

    
        if (number < 0)
        {
         
            Console.WriteLine(number * -1);
        }
        else
        {
            
            Console.WriteLine(number);
        }
    }
}
