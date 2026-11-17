using System;

class Nodeee
{
    public int data;
    public Nodeee Next;
    public Nodeee(int value)
    {
        data = value;
        Next = null;
    }
}

class Linklist
{
   public Nodeee head;

    public void End(int value)
    {
        Nodeee mp = new Nodeee(value);

        if (head == null)
        {
            head = mp;
            return;
        }
        Nodeee Temp = head;
        while (Temp.Next != null)
        {
            Temp = Temp.Next;
        }
        Temp.Next = mp;

    }

    public void Alter()
    {
        if(head==null)
        {
            Console.WriteLine("Data is not in Linked List");


        }

        Nodeee current = head;
    while(current.Next!=null && current!=null )
        {
            Console.Write(current.data + "->");
            current = current.Next.Next;

            


        }

    if(current!=null)
        {
            Console.Write(current.data);
        }

        

    }

    
}


class Alternate
{
    public static void Run()
    {
        Linklist ch = new Linklist();
        ch.End(1);
        ch.End(2);
        ch.End(3);
        ch.End(4);
        ch.End(5);
        ch.End(6);
        ch.End(7);

        ch.Alter();
        
    }
}