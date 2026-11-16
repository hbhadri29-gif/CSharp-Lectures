using System;

class Pro
{

static int GetNumber()
{
int[] z=new int[] {10,20,30,40};
int p = z[0];
int i;
for(i=0;i<4;i++)
{if(p>z[i])
p=z[i];

}
return p;
}

static void Main()
{
int numbers = GetNumber();
Console.WriteLine("the smallest number is" + numbers);


}}