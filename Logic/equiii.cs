using System;

class equiii

{

static void Main()
{

int i,m,j,k=10;
for(i=1;i<=10;i++)
{
for(j=10;j>=k;j--)
{

Console.Write("  ");
}
for(m=1;m<=k;m++)
{
Console.Write(" * ");

}

k=k-1;

Console.WriteLine("");
}
}
}
