using System;
 namespace Arr
{
    public class arrr
    {
        int[] arr;
        public void Main(int i,int n)
        {
            Console.WriteLine("Enter the size of array");
            n= int.Parse(Console.ReadLine());
            arr =new int[n];
            for(i=0;i<n;i++)
            {
                arr[i]=int.Parse(Console.ReadLine());

            }   
        for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
          
    }

        }