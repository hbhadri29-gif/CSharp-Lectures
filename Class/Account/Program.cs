using System;



class Bank
{
    int acno;
    string acname;
    double amt, deamt = 10000;
    public void Account(int ano, string an)
    {
        acno = ano;
        acname = an;
    }
    public void deposit()
    {
        Console.WriteLine("Enter amount to deposit");
        amt = double.Parse(Console.ReadLine());
        deamt = deamt + amt;
    }
    public void withdraw()
    {
        Console.WriteLine("Enter amount to withdrawl ");
        amt = double.Parse(Console.ReadLine());
        if (deamt < amt)
            Console.WriteLine("Cannot withdraw amount ");
        else
        {
            Console.WriteLine("Amount withdrawn possible ");
            deamt = deamt - amt;
            Console.WriteLine("Amount remaining after withdrawl " + deamt);
        }
    }
    static void Main()
    {
        /* Bank bk = new Bank();

        Console.WriteLine("Enter account holder name");
        string anme = Console.ReadLine();
        Console.WriteLine("Enter the account number");
   
        int no= int.Parse(Console.ReadLine());
        bk.Account(no, anme);
        bk.deposit();
        bk.withdraw(); */

        /*  Pro pm = new Pro();
          Console.WriteLine("Enter the number");
          int n = int.Parse(Console.ReadLine());
          pm.Prime(n);
          pm.Prime();  */

        Pr rk = new Pr();
        rk.fact();
        Console.WriteLine("Enter the number");
        int j = int.Parse(Console.ReadLine());
        rk.fact(j);
    }
}