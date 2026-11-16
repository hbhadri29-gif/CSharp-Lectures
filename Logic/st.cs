using System;

class st
{

static void Main()
{

char []chaar = new char[5];

int i=0;
Console.WriteLine("Enter the value");
for(i=0;i<chaar.Length;i++)
{
chaar[i]=char.Parse(Console.ReadLine());
}
Console.WriteLine("The cahr are");
 for(i=0;i<chaar.Length;i++)
{

Console.WriteLine(chaar[i]);
}
int digi=0,cha=0,sym=0;
for(i=0;i<chaar.Length;i++)
{
if(chaar[i]>='0' && chaar[i]<='9')
{
digi=digi+1;
}

else if(chaar[i]>='a' && chaar[i]<='z')
{
cha=cha+1;
}

else
{
sym=sym+1;
}
}
Console.WriteLine($"Digits{digi} Chara{cha} Symbols{sym}");
}
}
