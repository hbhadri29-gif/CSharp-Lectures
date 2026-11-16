using System;

class aru
{
static void Main()
{
try{

int []arr;

int i,c;
Console.WriteLine("enter the size of array");
c= int.Parse(Console.ReadLine());


arr = new int[c];
Console.WriteLine("enter the elements in arrray");
for(i=0;i<c;i++)

{

arr[i]= int.Parse(Console.ReadLine());
}

Console.WriteLine("The ele are");
for(i=0;i<c;i++)

{
Console.WriteLine(arr[i] + " ");
}
}
catch(System.FormatException fe)
{
Console.WriteLine(" Kindly Check your input" + fe.Message);
}

catch(System.OverflowException Oe)
{

Console.WriteLine("Kindly put postive variables" + Oe.Message);
}
}
}

