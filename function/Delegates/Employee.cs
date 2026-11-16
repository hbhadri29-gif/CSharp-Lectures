using System;

class Employee
{

public string Name;
public int Salary;
}                                                                                               

class Program
{
public delegate double Bonus(Employee emp);

static double  CalBonus(Employee emp)
{

if (emp.Salary<3000)
return 0.5*emp.Salary;
else if(emp.Salary<40000)
return 0.10*emp.Salary;
else
return 0.15*emp.Salary;
}

static void Main()
{

Employee emp= new Employee
{

Name="Himanshu",
Salary = 100000
};

Bonus bn= CalBonus;

Console.WriteLine("Employee:" + emp.Name);

Console.WriteLine("Employee:" + bn(emp));
}
}