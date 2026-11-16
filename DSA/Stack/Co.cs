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

class MyLinkedList
{
    Node head;

    // Insert a node at the end
    public void InsertAtEnd(int value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
            return;
        }

        Node temp = head;

        while (temp.next != null)
        {
            temp = temp.next;
        }

        temp.next = newNode;
    }

    // Insert a node at the beginning
    public void InsertAtBeginning(int value)
    {
        Node newNode = new Node(value);

        newNode.next = head;
        head = newNode;
    }

    // Display the linked list
    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("Linked list is empty.");
            return;
        }

        Node temp = head;

        while (temp != null)
        {
            Console.Write(temp.data + " -> ");
            temp = temp.next;
        }

        Console.WriteLine("NULL");
    }

    // Count the nodes
    public int CountNodes()
    {
        int count = 0;
        Node temp = head;

        while (temp != null)
        {
            count++;
            temp = temp.next;
        }

        return count;
    }

    // Search for an element
    public bool Search(int value)
    {
        Node temp = head;

        while (temp != null)
        {
            if (temp.data == value)
                return true;

            temp = temp.next;
        }

        return false;
    }

    // Delete the first occurrence of a value
    public void Delete(int value)
    {
        if (head == null)
        {
            Console.WriteLine("Linked list is empty.");
            return;
        }

        // If the first node contains the value
        if (head.data == value)
        {
            head = head.next;
            return;
        }

        Node temp = head;

        while (temp.next != null &&
               temp.next.data != value)
        {
            temp = temp.next;
        }

        if (temp.next == null)
        {
            Console.WriteLine("Element not found.");
            return;
        }

        temp.next = temp.next.next;
    }

    static void Main()
    {
        MyLinkedList list = new MyLinkedList();

        list.InsertAtEnd(10);
        list.InsertAtEnd(20);
        list.InsertAtEnd(30);
        list.InsertAtEnd(40);

        Console.WriteLine("Original Linked List:");
        list.Display();

        list.InsertAtBeginning(5);

        Console.WriteLine("\nAfter inserting 5 at the beginning:");
        list.Display();

        Console.WriteLine("\nNumber of nodes: " + list.CountNodes());

        int key = 30;

        if (list.Search(key))
            Console.WriteLine(key + " found in the list.");
        else
            Console.WriteLine(key + " not found in the list.");

        list.Delete(20);

        Console.WriteLine("\nAfter deleting 20:");
        list.Display();
    }
}