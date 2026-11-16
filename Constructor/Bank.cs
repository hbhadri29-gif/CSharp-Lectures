using System;

class Bank
{
static Bank()
{
Console.WriteLine("Nishat Bank");
}
}

class Car
{
static Car()
{
int Totalcars=100;
Console.WriteLine("");
}
}


class Laptop
{
static Laptop()
{
Console.WriteLine("2 years");
}
}


class Lib
{
static Lib()
{
Console.WriteLine("Book1");
}
}


class temp
{
static temp()
{
Console.WriteLine("enter temp in cel");
int cel=int.Parse(Console.ReadLine());
int far=(cel*2/5)+32;
Console.WriteLine(far);
}
}

class Pro
{
static void Main()
{
Lib obj=new Lib();
temp obj1=new temp();
Laptop obj2=new Laptop();
Bank obj3=new Bank();
Car obj4=new Car();
}
}