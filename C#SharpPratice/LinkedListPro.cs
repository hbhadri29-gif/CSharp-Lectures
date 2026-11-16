
using System;
class Node
{

    public int data;
    public Node next;
    public Node(int value)
    {
        data = value;
        next = null;
    }
}

class LinkedList
{
    Node head;
    public void End(int value)
    {
        Node newnode = new Node(value);

        if (head == null)
        {
            head = newnode;
            return;
        }

        Node temp = head;

        while (temp.next != null)
        {
            temp = temp.next;
        }

        temp.next = newnode;
    }

    public void Display()
    {

        if (head == null)
        {
            Console.WriteLine("LinkedList is Empty");
        }

        Node temp = head;

        while (temp != null)
        {
            Console.Write(temp.data + "->");
            temp = temp.next;
        }
    }

}

class LinkedListPro
{
    public static void Run()
    {

        LinkedList my = new LinkedList();
        my.End(30);
        my.End(40);
        my.End(50);
        my.End(60);
        my.End(70);

        my.Display();

    }
}