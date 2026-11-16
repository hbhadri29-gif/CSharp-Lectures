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

public void End(int value)
{

Node newnode = new Node(value);

if(head == null)
{
 head=newnode;
return;
}

Node temp = head;

while(temp.next != null)
{
temp= temp.next;
}
temp.next = newnode;
}

public void Display()
{

if(head==null)
{
Console.WriteLine("Linked list is empty");
return;
}

Node temp=head;

while (temp!=null)
{
Console.Write(head + "->");
temp=temp.next;
}
}
}
class Program
{
public static void Main()
{

MyLinkedList my =  new MyLinkedList();

my.End(50);
my.End(20);
my.Display();
}
}