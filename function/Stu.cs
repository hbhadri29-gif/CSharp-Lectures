using System;

class Stu
{

public string name;
public int age;
}

class Pro
{

static Stu GetStudent()
 {
return new Stu
{
name="Himanshu",
age=29

};
}
static void Main()
{
Stu s= GetStudent();
Console.WriteLine(s.name);
Console.WriteLine(s.age);
}}


