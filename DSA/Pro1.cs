using System;

 class Pro
{



int i;
int n;
int []arr;
public void input()
{

Console.WriteLine("ENter the size of array");

try{
n=int.Parse(Console.ReadLine());


if(n<=0 )
{

Console.WriteLine("size is less than zero");
}

else
{
arr= new int[n];
Console.WriteLine("Enter the elementts ins aray");
for(i=0;i<n;i++)
{

arr[i]=int.Parse(Console.ReadLine());


}
}
}
catch(FormatException)
{
Console.WriteLine("DOnt put other value than int");
}
}
public void oper()
{
n=n-1;
}
public void display()
{

Console.WriteLine("Array is");
for(i=0;i<n;i++)
{
Console.Write(arr[i]);
}
}


static void Main()
{

Pro p1= new Pro();
p1.input();
p1.oper();
p1.display();

}
}