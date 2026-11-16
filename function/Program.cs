 using System;


class Program
{

public static int sum(int a)
{

int i;
int s=0,j=0;
while(a>0)
{
j=a%10;
s=s+j;
a=a/10;

}
return s;
}
static void Main()
{
int sb= sum(1234);
Console.WriteLine("answer is" + sb); 

}
}