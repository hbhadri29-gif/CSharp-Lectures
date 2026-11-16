using System;

class Program1
{
 

public string Func(string nm)
{
 int i;
string res="";
string rev="";
for(i=nm.Length-1;i>=0;i--)
{
rev=rev+nm[i];


}

return rev;
}
static void Main()
{
Program1 pr= new Program1();
Console.WriteLine(pr.Func("Hima and"));
}


}

