using System;

class Him
{

string user;
string pass;

public Him(string us,string pas)
{

user=us;
pass=pas;


}

public static bool operator ==(Him h1,Him h2)
{

{return h1.user==h2.user && h1.pass==h2.pass;}


}

public static bool operator !=(Him h1,Him h2)
{


{return h1.user!=h2.user && h1.pass!=h2.pass;}

}

static void Main()
{

string c="himanshu";
string d="password";
Console.WriteLine("Enter the user and pass");
string f=Console.ReadLine();
string g=Console.ReadLine();
Him h3 = new Him(c,d);
Him h4 = new Him(f,g);
Console.WriteLine(h3==h4);
Console.WriteLine(h3!=h4);
}
}
