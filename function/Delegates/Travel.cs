using System;

class Travel
{

string name;
int age,distance;
int fare;
public void Passenger(string n, int a, int dis)
{

name=n;
age=a;
distance=dis;
}
int bfare = 1.20;
string classs;
public static int Trave()
{
  if(classs=="sleeper")
{
    fare =bfare*distance;
     return fare;
}    
  else if(classs="AC 3 Tier")
  { int a= cbfare*distance;
   int b=distance*0.50;
 fare =a+b;
return fare;
}
  else if(classs = "AC 2 tier")
 { int c= bfare*distance;
  int d = distance * 1;
  fare= c+d;
return fare;}
else if(classs = "First AC")
 {
int j= bfare*distance;
 int i = distance*2;
 fare= j+i;
 return fare;
}
return fare;
}

public static int Discount()
{
 if(age<5 )
 return fare*0;
 else if(age=>5 && age<=11)
 return fare*0.5;
 else if(age>60)
 return fare;
 
else
 return fare;
}
static void Main()
{


Travel tr = new Travel();
Console.WriteLine("Enter the Name of Passenger");
string nm= Console.ReadLine();
Console.WriteLine("Enter the Age of Passenger");
int ag= int.Parse(Console.ReadLine());
Console.WriteLine("Enter the distance Travelled");
string ds= Console.ReadLine();

tr.Passenger(nm,ag,ds);
Console.WriteLine("ENter the class");
string clss=Console.ReadLine();
tr.Trave(clss);

tr.Discount();
 
}
}