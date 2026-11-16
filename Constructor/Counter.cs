using System;

class Counter
{
int to;
int age;
int count;
public Counter(int agee)
{
age =agee;
}

public void increase()
{
count = age+to;
Console.WriteLine(count);
}
public void decrease()
{
count=age-to;
Console.WriteLine(count);
}
public void toval(int j)
{

to=j;
}


static void Main()
{Console.WriteLine("ENter the choice 1 for inc and 2 for dec");
int cho=int.Parse(Console.ReadLine());
int value;
int age;
Console.WriteLine("Enter the number");
age=int.Parse(Console.ReadLine());
Counter ct = new Counter(age);
Console.WriteLine("You want to inc or dec");
value=int.Parse(Console.ReadLine());
if(age>0)
{
ct.toval(value);
}

else
{
Console.WriteLine("Cant decrease");
}
switch (cho)
{

case 1:
ct.increase();
break;

case 2:
ct.decrease();
break;

default:
Console.WriteLine("IC");
break;
}

}

}