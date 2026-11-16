using System;

class Node
{
public int data;
public Node next;
public Node(int value)
{

data =value;
next =null;

}

}

class Linkedlist
{

Node head;

public void End(int value)
{

Node newnode = new Node(value);


if(head==null)
{
head = newnode;
return;
}

Node temp=head;

while(temp.next!=null)
{
temp=temp.next;
}

temp.next=newnode;
}

public void begin(int value)
{

Node newnode = new Node(value);
newnode.next=head;
head=newnode;


}

public bool Search(int value)
{
Node temp=head;

 if(temp==null)
{
Console.WriteLine("No ele are found");
return false;
}

while(temp!=null)
{
if(temp.data==value)
 return true;
temp = temp.next;


}

return false;
}

public void Count()
{
Node temp=head;
int count=0;
while(temp!=null)
{
count++;
temp=temp.next;
}
Console.WriteLine("total nodes are " + count);
}

public void Display()
{
Node temp=head;
if(head==null)
{
Console.WriteLine(" No element to display");
return;
}
Console.WriteLine("");
while(temp!=null)
{
Console.Write(temp.data+ "->");
temp=temp.next;
}
}

public void Delete(int value)
{
if(head==null)
{
Console.WriteLine("Linkedlist is empty");

}
if(head.data==value)
{
head=head.next;
return;
}
Node temp=head;

while(temp!=null
&& temp.next.data!=value)
{
temp=temp.next;
}

if(temp==null)
{
Console.WriteLine("Ele not found");
return;
}

temp.next=temp.next.next;
}
}
class Program()
{
static void Main()
{
Linkedlist my = new Linkedlist();
my.End(20);
my.End(30);
my.End(40);
my.End(50);
my.End(60);

my.Display();
my.begin(70);
my.Display();
if(my.Search(50))
{
Console.WriteLine("element is found");
}
else
{
Console.WriteLine("Not found at all");
}

my.Count();
my.Delete(50);
my.Display();
}
}

