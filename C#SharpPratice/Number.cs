
using System;
using System.Security.Cryptography.X509Certificates;

class Nde
{
    public int data;
    public Nde next;

    public Nde(int value)
    {
        data = value;
        next = null;
    }
}

class Linklisst
{
    Nde head;
    public int count = 0;
    public void End(int value)
    {
        Nde npp = new Nde(value);

        if (head == null)
        {
            head = npp;
            return;
        }

        Nde temp = head;
        while (temp.next != null)
        {

            temp = temp.next;

        }
        temp.next = npp;
    }

    public void Display()
    {

        if (head == null)
        {
            Console.WriteLine("No data in linkedlist");
            return;
        }

        Nde temp = head;

        while (temp != null)
        {
            count++;
            temp = temp.next;
        }


    }

    public void nu (int value)
        {
        Nde temp = head;
        int final = count - value;
        int op=0;

        while(temp!=null)
        {
            if(op!=final)
            {
                
                temp = temp.next;
                op++;
                while(op==final&& temp!=null)
                {
                    Console.Write(temp.data + "->");
                    temp = temp.next;
                }
            }
        }
        

        }
}


class Number
{
   public static void Run()
    {
        Linklisst ch = new Linklisst();

        ch.End(40);
        ch.End(50);
        ch.End(60);
        ch.End(70);
        ch.End(80);
        ch.End(90);
        ch.Display();
        ch.nu(4);
    }




}