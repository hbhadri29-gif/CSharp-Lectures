using System;
 namespace Arr
{
    public class Arrr
    {
        int[] ar;
        int i;
        public void Mam(int n)
        {;
            ar =new int[n];
     
            for(i=0;i<n;i++)
            {
                Console.WriteLine("Enter a number");
                ar[i]=int.Parse(Console.ReadLine());

            }   
        for (i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(ar[i]);
            }
        }
          
    }

        }