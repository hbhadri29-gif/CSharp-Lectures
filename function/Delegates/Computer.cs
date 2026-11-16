using System;

class Param
{

public delegate void Mydel();


static void Computer()
{

Console.WriteLine("Computer needs to be upgraded");
}

static void Main()
{

Mydel del = Computer;

Computer();

}
}