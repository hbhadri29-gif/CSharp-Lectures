using System;


class strng
{

static string str(string z)
{

string rev="";
int i;
for(i=z.Length-1;i>=0;i--)
{
rev +=z[i];
}

return rev;
}

static void Main()
{
string strr =str("Hello");
Console.WriteLine("The rev string is" + strr);

}}