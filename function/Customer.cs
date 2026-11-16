using System;

public class Customer
{

 public string Name;
}
public class order
{
public int orders;

public Customer Customer;

public double total;

}

class Program
{
 static order GetCustomer()
{
return new order
{
orders=101,
Customer = new Customer
{
Name="armaan"
},
total=2500

};
}




static void Main()
{

order obj= GetCustomer();
Console.WriteLine(obj.orders);
Console.WriteLine(obj.Customer.Name);
Console.WriteLine(obj.total);
}
}
