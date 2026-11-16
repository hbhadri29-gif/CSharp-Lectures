using System;

class tech

{
static void Main()
{
Console.WriteLine("Enter the number");
int n= Convert.ToInt32(Console.ReadLine());
int i,k,p,s=0,y=0,count=0,rem,j=2,l,g,r=0,po,op,sum;
int b=n;
int a=b;
count=0;

while(n>0)
{





n=n/10;
count=count+1;


}
Console.WriteLine(count);
l=count/2;
Console.WriteLine(l);
for(k=1;k<=l;k++)
{
p=b%10;
y=(y*10)+p;
b=b/10;
}
Console.WriteLine(b);
while(y>0)
{
g=y%10;
r=(r*10)+g;
y=y/10;
}
Console.WriteLine(r);
sum=r+b;
op=sum*sum;
Console.WriteLine(op);
Console.WriteLine(count);
if(count%2==0 && a==op)
{
Console.WriteLine("Number is tech");
}
else
{
Console.WriteLine("Number is not tech");
}

}
}