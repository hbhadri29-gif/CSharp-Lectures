using System;

class Student 
{
int markks;
int semm;
int rolll;
string namee;
string coursee;
public Student()
{
}

Student(string name,int roll)
{
namee=name;
rolll = roll;
}
Student(Student c1, string Course)
{
namee=c1.namee;
rolll=c1.rolll;
coursee=Course;
}
Student(Student c2, int sem,int marks)
{
namee=c2.namee;
rolll=c2.rolll;
coursee=c2.coursee;
markks= marks;
semm=sem;
}
public void  stu1()
{
Console.WriteLine("The roll no is " + rolll);
Console.WriteLine("The name is " + namee);
Console.WriteLine("The course is " + coursee);
Console.WriteLine("The marks is " + markks);
Console.WriteLine("The sem is " + semm);
}


static void Main()
{Student stu1= new Student("Himanshu",1);
stu1("Him", 2);
Student stu2= new Student(stu1,"Bsc");
Student stu3= new Student(stu2, 1,23);
stu3.stu1();

}


}