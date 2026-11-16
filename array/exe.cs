using System;

class exe
{

static void Main()
{
try{
int []arr;
int []arrr;

int i,n;
 Console.WriteLine("enter the size of arrray");
n= int.Parse(Console.ReadLine());

arr = new int[n];
arrr = new int[n];

Console.WriteLine("enter the ele in arr");
for(i=0;i<n;i++)
{
arr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("enter the 2 ele in arr");
for(i=0;i<n;i++)
{
arrr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("enter the ele in arr");
for(i=0;i<n;i++)
{
Console.WriteLine(arr[i] / arrr[i]);
}

}
catch(System.OverflowException fe){
Console.WriteLine("Kindly put postive variable" + fe.Message);
}
catch(System.FormatException oee)
{
Console.WriteLine("KIndly put the correct value" + oee.Message);
}

catch(System.DivideByZeroException oee)
{
Console.WriteLine("Dont divide by zero dont be cruel" + oee.Message);
}
}
}