using System;
using System.Collections.Generic;

class Pro
{
 static void Main()
{

Queue<string> q = new Queue<string>();

q.Enqueue("Earth");
q.Enqueue("Mars");

Console.WriteLine("Current ele are " + q.Peek());
q.Dequeue();
Console.WriteLine("Current ele are " + q.Peek());
}
}