using System;

class Nod
{
    public int data;
    public Nod next;

    public Nod(int value)
        {
        Nod next;

        data = value;
    }
}

class ListLink
{
    Nod head;

   public void End(int value)
    {
        Nod nee = new Nod(value);

        if (head == null)

        {
            head = nee;
            return;

        }

        Nod temp = head;

        while(temp.next!=null)
        {

            temp = temp.next;


        }

        temp.next = nee;
        temp = temp.next;

    }


    public void Circ()
    {
        if(head==null)
        {
            Console.WriteLine("linked list is empty");



        }

        Nod current = head;
        Nod temp = head;
        while(current.next!=null)
        {
            current = current.next;
            temp.next = current;
            temp = temp.next;
            
           
           
            Console.Write(temp.data);
        }


    } 

    public void Display()
    {
        if(head==null)

        {
            Console.WriteLine("No data");
            return;
        }

        Nod temp = head;

        while(temp!=null)
        {
            Console.Write(temp.data + "->");
            temp = temp.next;
        }
    }
}

class Circular
{
    public static void Run()
    {
        ListLink hb = new ListLink();

        hb.End(1);
        hb.End(2);
        hb.End(3);
        hb.End(4);
        hb.End(5);



        hb.Circ();
       // hb.Display();

    }
}