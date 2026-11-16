using System;

class Nodee
{
    public int data;
    public Nodee next;
    public Nodee(int value)
    {
        data = value;
        next=null;
    }
}

class LinkeddList
{
    Nodee head;

    public void End(int value)
    {
        Nodee newnode = new Nodee(value);

        if(head==null)
        {
            head = newnode;
            return;

        }

        Nodee temp = head;

        while(temp.next!=null)
        {
            temp = temp.next;
        }

        temp.next = newnode;
    }

    public void Filter()
    {
        if(head==null)
        {
            Console.WriteLine("LinkedList is empty");


        }
        Nodee temp = head;

        while(temp!=null)
        {
            if(temp.data%2==0)
            {
                Console.Write(temp.data + "->");
            }
            temp = temp.next;
        }
    }
}

class Even
{
    public static void Run()
    {
        LinkeddList lp = new LinkeddList();
        lp.End(7);
        lp.End(6);
        lp.End(5);
        lp.End(4);
        lp.End(3);
        lp.End(2);
        lp.End(1);

        lp.Filter();
    }
   
}