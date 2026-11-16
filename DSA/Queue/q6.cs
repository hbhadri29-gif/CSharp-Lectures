using System;
using System.Collections.Generic;

class Pro
{
static void Main()
{
Queue <string> q = new Queue<string>();

q.Enqueue("Himanshu");
q.Enqueue("Raj");
q.Enqueue("Vipin");
q.Enqueue("Vikas");

string [] arr = new string[q.Count];

q.CopyTo(arr,0);
string ss=arr[0];
int a=arr[0].Length;
for(int i=0;i<arr.Length;i++)
{

if(arr[i].Length>a)
{
a=arr[i].Length;
ss=arr[i];
}

}
Console.WriteLine(a);
Console.WriteLine("The longest string is" + ss);
}
}

