using System;

class MyQueue
{
    int[] arr;
    int front;
    int rear;
    int size;

    public MyQueue(int size)
    {
        arr = new int[size];
        front = 0;
        rear = -1;
        this.size = size;
    }

    public void Enqueue(int value)
    {
        if (rear == size - 1)
        {
            Console.WriteLine("Queue is full");
            return;
        }

        arr[++rear] = value;
    }

    public int Dequeue()
    {
        if (front > rear)
        {
            Console.WriteLine("Queue is empty");
            return -1;
        }

        return arr[front++];
    }

    public void Sort()
    {
        // Bubble Sort
        for (int i = front; i <= rear; i++)
        {
            for (int j = front; j < rear - (i - front); j++)
            {
Con
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    public void Display()
    {
        for (int i = front; i <= rear; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        MyQueue q = new MyQueue(5);

         q.Enqueue(5);
         q.Enqueue(7);
         q.Enqueue(3);
         q.Enqueue(2);
         q.Enqueue(9);
     

        Console.WriteLine("Before Sorting:");
        q.Display();

        q.Sort();

        Console.WriteLine("After Sorting:");
        q.Display();
    }
}