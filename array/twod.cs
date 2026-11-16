using System;


class twod

{

static void Main()
{

int[,] arr={{1,2,3},{4,5,6},{7,8,9}};
int i,j;
int rows = arr.GetLength(0);
int cols=  arr.GetLength(1);

Console.WriteLine("Iterating loop through 2d array");

for(i=0; i<rows;i++)
{

for (j=0; j<cols; j++)
{
Console.Write( arr[i,j] + " ");
}
Console.WriteLine(" ");

}

}
}