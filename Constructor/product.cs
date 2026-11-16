using System;

class product
{
string name;
int weight=1;
product(string namee)
{
 name=namee;

 
Console.WriteLine("product name is " + name);
Console.WriteLine("product weight is " + weight);
}

 product(product pp,string location)
{
name=pp.name;
Console.WriteLine("Location is" + location);
}
 product(product pp,int weight)
{
name=pp.name;
string location="warehouse";
Console.WriteLine("Product name is" + name);
Console.WriteLine("Product weight is" + weight);
Console.WriteLine("product location is " + location);

}

static void Main()
{

product p1=new product("mobile");
Console.WriteLine("Pro is "+ p1.name);
product p2= new product(p1,"warehose");
Console.WriteLine("Pro is "+ p2.name);
product p3= new product(p1,1);
Console.WriteLine("Pro is "+ p3.name);
}
}