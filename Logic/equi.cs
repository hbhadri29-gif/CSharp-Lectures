using System;


class equi
{

static void Main()

{

int i,j,k=1,f;


for (i=1;i<=10;i++)
{
for(f=10;f<=i;f--)
{
Console.Write("  ");
}
for(j=1;j<=i;j++)
{

Console.Write(" * ");
}
Console.WriteLine(" ");
}
}
}