using System;

class Employee
{

public int id;
public string name;
public int sal;

public Employee cal(int i,string s,int ss)
{

id=i;
name=s;
sal=ss;


if(ss==50000)
{

Console.WriteLine( name +"His salary is 50k");
}

else
{

Console.WriteLine("sal is less or more");
}
return new Employee();

}

static void Main()
{
Console.WriteLine("Enter the id");
int idd =int.Parse(Console.ReadLine());
Console.WriteLine("Enter the name");
string nm= Console.ReadLine();

Console.WriteLine("enter the salary");
int sa =int.Parse(Console.ReadLine());

Employee emp= new Employee();
Employee empp= emp.cal(idd,nm,sa);

}
}
