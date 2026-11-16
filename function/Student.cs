using System;

class Student
{

public string Name;
public int Roll;
public int Marks;

public Student GetStudent()
{
return new Student{

Name="Himanshu",
Roll=1,
Marks=44


};
}


}

class Program
{

static void Main()
{

Student s = new Student();
 Student st = s.GetStudent();
Console.WriteLine(st.Name);

Console.WriteLine(st.Roll);

Console.WriteLine(st.Marks);
}}