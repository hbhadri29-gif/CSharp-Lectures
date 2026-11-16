using System;

class TestUnboxing
{
static void Main()
{
 int num= 123;
object obj= num;

try{

int j = (short) obj;

System.Console.WriteLine("unbpxing");
}
catch(System.InvalidCastException e)
{
Console.WriteLine("{0} Error: Incorrect Unbox", e.Message);
}
Console.Read();
}
}