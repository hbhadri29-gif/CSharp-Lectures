using System;

class MyQueue
{
    int[] queue;
    int front;
    int rear;
    int size;

    public MyQueue(int capacity)
    {
        queue = new int[capacity];
        front = 0;
        rear = -1;
        size = 0;
    }
    public void Enqueue(int value)
    {
        if (size == queue.Length)
        {
            Console.WriteLine("Queue is Full");
            return;
        }

        rear++;
        queue[rear] = value;
        size++;

        Console.WriteLine(value + " inserted");
    }
    public void Dequeue()
    {
        if (size == 0)
        {
            Console.WriteLine("Queue is Empty");
            return;
        }

        Console.WriteLine(queue[front] + " removed");
        front++;
        size--;
    }
    public void Display()
    {
        if (size == 0)
        {
            Console.WriteLine("Queue is Empty");
            return;
        }

        Console.WriteLine("Queue elements:");

        for (int i = front; i <= rear; i++)
        {
            Console.Write(queue[i] + " ");
        }

        Console.WriteLine();
    }

    public void Peek()
    {
        if (size == 0)
            Console.WriteLine("Queue is Empty");
        else
            Console.WriteLine("Front = " + queue[front]);
    }
}

class Program
{
    static void Main()
    {
     Console.WriteLine("ENter the size of queuuq");
  int size = int.Parse(Console.ReadLine());

  
        MyQueue q = new MyQueue(size);

  


Console.WriteLine("Enter the values");
int a= int.Parse(Console.ReadLine());
int b= int.Parse(Console.ReadLine());
int c= int.Parse(Console.ReadLine());
int d= int.Parse(Console.ReadLine());
int e= int.Parse(Console.ReadLine());
        
        q.Enqueue(a);
        q.Enqueue(b);
        q.Enqueue(c);
        q.Enqueue(d);
        q.Enqueue(e);


        q.Display();

        q.Peek();

        q.Dequeue();
        q.Display();

        q.Dequeue();
        q.Display();
    }
}