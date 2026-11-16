using System;

class ticket
{
string []arr;
int front;
int rear;
int size;
string status;
public ticket(int cap)
{
arr = new string[cap];
front=0;
rear=-1;
size=0;
status=" ";
}
public void Enqueue(string val)
{
 
if(size==arr.Length)
{
Console.WriteLine("Ticket queue is full try again later");

return;
}
rear++;
arr[rear]=val;
size++;
}

public void Dequeue()
{
if(size==0)
{
Console.WriteLine("There is no tickets is Queue");
return;
}

size--;
front++;
}

public void Display()
{
Console.WriteLine("Ticket Number" + "Ticket Subject");
for(int i=front;i<arr.Length;i++)
{
Console.WriteLine( i + " " + arr[i]);
}
}
public void Status( string status)
{

if(status=="solved")
{


Dequeue();
}
}
}
class Program
{
static void Main()
{

ticket q = new ticket(5);
q.Enqueue("Wifi Issue");
q.Enqueue("Outlook Issue");
q.Enqueue("Computer Issue");
q.Enqueue("Cpu Issue");
q.Enqueue("Ethernet Issue");

q.Display();

Console.WriteLine("Enter the status");
string s=Console.ReadLine();
q.Status(s);
q.Display();
}
}