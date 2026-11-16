using System;

class app

{
static void Main()
{

int []arr;
 int i,n,j,a;

Console.WriteLine("Enter the size ofa array");

n= int.TryParse(Console.ReadLine());

arr = new int[n];

Console.WriteLine("ENter the array ele");

for(i=0;i<n;i++)
{
 arr[i]= int.Parse(Console.ReadLine());

}

for(i=0;i<n;i++)
{

for(j=0;j<n;j++)
{
