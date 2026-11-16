using System;

class Text
{

string Content;

public Text(string content)
{

Content=content;

}

public static Text operator +(Text a,Text b)
{

return new Text(a.Content + " " +
 b.Content);
}

static void Main()
{
Console.WriteLine("Enter The Text");
string c = Console.ReadLine();
string d=Console.ReadLine();
Text s1 = new Text(c);
Text s2 =new Text(d);
Text s3 = s1+s2;
Console.WriteLine(s3.Content);

}
}