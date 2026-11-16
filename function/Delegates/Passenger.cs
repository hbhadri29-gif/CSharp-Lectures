using System;

class Passenger
{
  string name;
int age;
double dist,chrg,chrg1,tchrg=0;
string  tclass;
void GetDetails()
{
 Console.WriteLine("Enter the name age and distance");
name=Console.ReadLine();
age=int.Parse(Console.ReadLine());
dist=double.Parse(Console.ReadLine());
tclass=Console.ReadLine();
}
void Calcharges()
{
 if(tclass == "Sleeper")

   chrg=0.0;
else if(tclass=="AC 3 tier")
  chrg =dist*0.5;
else if(tclass=="AC 2 tier")
 chrg =1*dist;

else if(tclass=="First AC")
 chrg =2*dist;

if(age<5)
chrg1=0.0;

else if(age>=5 && age<=11)
chrg1=0.25;


else if(age>60)
 chrg1=0.30;
else
chrg1=0.0;

tchrg =dist*1.20;
tchrg =chrg*chrg1+tchrg;
tchrg=tchrg+0.05*tchrg;
Console.WriteLine(tchrg);
}

static void Main()

{
Passenger p1= new Passenger();

p1.GetDetails();
p1.Calcharges();
}
}