using System;

public class Npde
{

   public int data;
   public Npde next;
    public Npde(int value)
    {
        data = value;
        next = null;

    }

}

class Link
{

    Npde head;

    public void End(int value)
    {

        Npde np = new Npde(value);

        if(head==null)
        {
            head = np;
            return;
        }

        Npde cirr = head;

        while(cirr.next!=null)
        {

            cirr = cirr.next;

        }

        cirr.next = np;

    }


    public void Disp()
    {

        if(head==null)
        {
            Console.WriteLine("Linkedlist is empty");
                return;

        }

        Npde current = head;

        while(current!=null)
        {
            Console.Write(current.data + "->");
            current = current.next;
        }

    }
  
    public void Compare()
    {
        Npde tem = head;
        Npde com = head;

        while(tem!= null)
        {
            if(com.data>tem.data)
            {
                com.data = tem.data;
            }
            tem = tem.next;
        }
        Console.WriteLine("The samlles ele is"+com.data);
    }
    

}

class Compar
{

    public static void Run()
    {

        Link li = new Link();

   
        Console.WriteLine("Enter the number of ele you wanna enter");
        int no = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the ele");
        for(int i =1;i<=no;i++)
        {
            int value=int.Parse(Console.ReadLine());
            li.End(value);
            value=0;
        }

   

        li.Disp();
        li.Compare();
    }
}