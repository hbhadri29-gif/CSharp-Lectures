
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
        Node nd = new Node(value);

        if (head == null)
        {
            head = nd;
            return;
        }

        Node temp = head;

        while (temp.next != null)
        {
            temp = temp.next;
        }

        temp.next = nd;
    }

    public void Reverse()
    {
        Node prev = null;
        Node current = head;
        Node next = null;

        while (current != null)
        {
            next = current.next;
            current.next = prev;

            prev = current;
            current = next;
        }

        head = prev;
    }

    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("Linked List is empty");
            return;
        }

        Node temp = head;

        while (temp != null)
        {
            Console.Write(temp.data + " -> ");
            temp = temp.next;
        }

        Console.WriteLine("null");
    }
}

class Program
{
    static void Main()
    {
        LinkedList my = new LinkedList();

        my.End(20);
        my.End(30);
        my.End(40);
        my.End(50);
        my.End(60);

        Console.WriteLine("Original Linked List:");
        my.Display();

        my.Reverse();

        Console.WriteLine("Reversed Linked List:");
        my.Display();
    }
}
