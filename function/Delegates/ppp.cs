using System;

class Program
{
    static void Main()
    {
        string input = "WINTER DAYS ARE GOOD DAYS";
        string[] words = input.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            char[] chars = words[i].ToCharArray();

            int left = 0;
            int right = chars.Length - 1;

            while (left < right)
            {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;

                left++;
                right--;
            }

            words[i] = new string(chars);
        }

        Console.WriteLine(string.Join(" ", words));
    }