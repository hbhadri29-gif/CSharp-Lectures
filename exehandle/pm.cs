using System;



class np : Exception
{
int o;
public np(int m)
{
o=m;

}
public override string ToString()
{
return (" Problem creator is" + o);
}
}

class pm 
{
static void Main()
{
int []arr;
 int i,j,k=0,n;

Console.WriteLine("Enter the size of arra");

n= int.Parse(Console.ReadLine());
arr= new int[n];
for(i=0;i<n;i++)
{
arr[i]=int.Parse(Console.ReadLine());
}

for(i=0;i<n;i++)
{
 for(j=1;j<=arr[i];j++)
{ if(arr[i]%j==0)
     {
         k=k+1;


   }
}
try{
if(k==2)
throw new np(arr[i]);

else
{
Console.WriteLine(arr[i]);
}
}
catch(np l)
{
Console.WriteLine( l);
}
k=0;
}



}
}
      
