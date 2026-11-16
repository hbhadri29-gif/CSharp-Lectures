using System;

class happy

{
 static void Main()

{

Console.WriteLine("Enetr the number");
int n= Convert.ToInt32(Console.ReadLine());
int g, rem,f=0,s=0;
int i,j=0;

while(n>0  && s==1)
{
  rem=n%10;
  s=(rem*rem)+s;
  n=n/10;
  while(f==1)
{
i=s%10;
f=s+f;
s=s/10;  
}
Console.WriteLine(f);
}
if(f==1)
{
Console.WriteLine("Number is very very happy");
}
else
{
Console.WriteLine("Number is sad");
}


}
}
  