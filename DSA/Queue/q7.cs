using System;
using System.Collections.Generic;
class Pro()
{
static void Main()
{
int []arr=new int[5];
Queue <int> q = new Queue <int>();
q.Enqueue(1);
q.Enqueue(5);
q.Enqueue(3);
q.Enqueue(4);
q.Enqueue(2);
int c=0;
int a=0;
q.CopyTo(arr,0);
for(int i=a;i<arr.Length-1;i++)
{

arr[i]=arr[i+1]+arr[i];
arr[i+1]=arr[i]-arr[i+1];
arr[i]=arr[i]-arr[i+1];
Console.WriteLine(i);
if(c==1 && i==arr.Length-2)
{
break;
}
else if(i==arr.Length-2 )
{

i=-1;
c=c+1;
}
}

for(int i=0;i<arr.Length;i++)
{
Console.Write(arr[i]);
}
}
}
