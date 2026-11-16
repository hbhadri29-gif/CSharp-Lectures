using System;

class Tex
{

string Content;

public Tex(string content)
{

Content =content;

}


public static Tex operator *(Tex a,int b)
{
string final=" ";
for(int i=0;i<b;i++)
{
final = a.Content+ final;

}
 Tex g = new Tex(final);
 return (g);
}



static void Main()
{
Console.WriteLine("Enter the text");
string c=Console.ReadLine();
Console.WriteLine("Enter the number your want multiply");
int d= int.Parse(Console.ReadLine());
Tex s1= new Tex(c);

Tex t2 = s1*d;

Console.Write(t2.Content);


}
}