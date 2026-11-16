using System;
class Primee
{
    bool isprime=true;
    bool isnot=false;
    public static Prime(int a)
    {
        int f=0;
        int i;
    for(i=1;i<=a;i++)
    { 
        if(a%i==0)
        
            f=f+1;
        
    }
        if(f==2)
        
            return isprime;
        
    else
    
        return isnot;
    
    }
    static void Main()
    {
        int Prm= Prime(20);
        Console.WriteLine("The number is not prime" + Prm);
    }
}