using System;
using System.Collections.Generic;
class Pro
{
static void Main()
{
 Queue <int> q = new Queue <int>();

q.Enqueue(3);
q.Enqueue(4);
q.Enqueue(5);
q.Enqueue(6);

int []array = new int[q.Count];

q.CopyTo(array,0);
Console.WriteLine("array");
for(int i=0;i<array.Length;i++)
{

Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Array in reverse order");

for(int i=array.Length-1;i>=0;i--)
{
Console.Write(array[i] + " ");
}
Console.WriteLine(" ");
}
}
