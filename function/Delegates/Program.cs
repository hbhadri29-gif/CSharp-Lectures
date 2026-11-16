using System;

class Program
{
public string name;
public int age;
public double dist,chrg,chrg1,tchrg;
public string tclass;

public void Det()
{
Console.WriteLine("Enter the details");
name=Console.ReadLine();
age=int.Parse(Console.ReadLine());
dist=double.Parse(Console.ReadLine());
tclass=Console.ReadLine();
}
public  double fun()
{
   if(tclass=="Sleeper")
   chrg =0.00;
  else if (tclass=="3 AC")
   chrg =0.5*dist;
  else if (tclass=="2 AC") 
    chrg =1*dist;
  else if(tclass=="1 AC")
     chrg=dist*2;
return chrg;
}

public double fb()
{
if(age<5)
   chrg1 =0.00;
  else if (age>=5&& age<=11)
   chrg1 =0.25;
  else if (age>60) 
    chrg1 =0.30;
else
chrg1=1;
  


tchrg=1.20*dist;
tchrg=chrg1*chrg+tchrg;
tchrg=tchrg+tchrg*0.05;

Console.WriteLine( tchrg);
return chrg1; 
}




static void Main()
{

Program pre = new Program();

pre.Det();
pre.fun();
pre.fb();

}
}