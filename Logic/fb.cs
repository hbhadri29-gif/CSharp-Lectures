using System;

class fb
{

static void Main()
{

string st1="deed";
string st2="ddfd";
int count1=0;
int count=0;
int i,j;

Console.WriteLine("The size of string1 is" + st1.Length);
Console.WriteLine("The size of string1 is" + st2.Length);

for(i=0;i<st1.Length;i++)
{

for(j=0;j<st2.Length;j++)
{
if(st1[i]==st2[j])
{

if(st1[j]==st2[i])
{
count=count+1;
}
else
{
count1=count+1;
}
}
}

}
Console.WriteLine(count1);
Console.WriteLine(count);


}
}