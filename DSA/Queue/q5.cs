using System;

using System.Collections.Generic;

class Pro()
{
 static void Main()
{

Queue <int> q= new Queue<int>();
q.Enqueue(4);
q.Enqueue(3);
q.Enqueue(1);
q.Enqueue(8);

int []arr = new int[q.Count];

q.CopyTo(arr,0);

Console.WriteLine("Enter the element you wana delete");
int a = int.Parse(Console.ReadLine());
int v= arr.Length;
int j=v-a;
Console.WriteLine(j);
int f=a;
int k=0;
for(int i=a;i<arr.Length-1;i++)
{

arr[f]=arr[f]+arr[f+1]; 
arr[f+1]=arr[f]-arr[f+1];
arr[f]=arr[f]-arr[f+1];
Console.WriteLine("Current ele");
Console.WriteLine(arr[i]);
Console.WriteLine("Next ele");
Console.WriteLine(arr[i+1]);

f++;

}
int size=v;
for(int i=0;i<arr.Length;i++)
{
if(size!=arr.Length-1)
{
size--;
}
else
{
break;
}
}


Console.WriteLine("array is");
for(int i=0;i<size;i++)
{
Console.WriteLine(arr[i] + " " + i);
}

}
}

