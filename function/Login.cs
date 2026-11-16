using System;

class Login
{

public string Message{get;set;}

public bool Success{get;set;}
}

class Program
{

static Login result(string username, string pass)
{
if(username=="admin" && pass=="123")
{
return new Login
{

Success=true,
Message="Login"
};
}
return new Login
{
Success=false,
Message="invalid"
};
}

static void Main()
{

Login res = result("admin","123");
Console.WriteLine(res.Success);
Console.WriteLine(res.Message);
}
}