using System;

class Thermostat
{

private double[] temperatureHistory = new Double[5];
private int count=0;

public void AddReading(double temperature)
{

if (count< temperatureHistory.Length)
{

temperatureHistory[count] = temperature;
count ++;
}
}
public void PrintHistory()
{
string[] readings =new string[count];
for(int i=0;i<count;i++)
{
readings[i]=temperatureHistory[i].ToString();
}
Console.WriteLine("temperature History:"+ string.Join(",", readings));
}
}

class Program
{
static void Main(string[] args)
{
Thermostat thermostat= new Thermostat();
Console.WriteLine("Enter the readings");

double[] arr= new double[4];
int i;
for(i=0;i<4;i++)
{
arr[i]=double.Parse(Console.ReadLine());
thermostat.AddReading(arr[i]);
}


thermostat.PrintHistory();
}
}