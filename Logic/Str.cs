using System;

class Str

{
static void Main()

{

char []charr= {'a','P','P','l','e'};

string lower= "";
string upper= "";
int i;

for(i=0;i<charr.Length;i++)
{
if(char.IsLower(charr[i]))
{
 lower = lower+charr[i];
}

else if(char.IsUpper(charr[i]))
{

upper=upper+charr[i];
}

}

Console.WriteLine($"Output is {lower}{upper}");
}
}
