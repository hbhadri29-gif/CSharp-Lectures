using System;

public class CircularQueue

{
    private int[] queue;
    private int front;
    private int rear;
    private int maxSize;

    // Constructor to initialize the queue with a fixed size
    public CircularQueue(int size)
    {
        maxSize = size;
        queue = new int[maxSize];
        front = -1;
        rear = -1;
    }

    // Check if the queue is full
    public bool IsFull()
    {
        return (rear + 1) % maxSize == front;
    }

    // Check if the queue is empty
    public bool IsEmpty()
    {
        return front == -1;
    }

    // Insert an element into the circular queue
    public void Enqueue(int item)
    {
        if (IsFull())
        {
            Console.WriteLine("Queue Overflow: Cannot insert " + item);
            return;
        }

        // If inserting the first element, move front to 0
        if (front == -1) 
        {
            front = 0;
        }

        // Circularly increment the rear pointer
        rear = (rear + 1) % maxSize;
        queue[rear] = item;
        Console.WriteLine($"Enqueued: {item}");
    }

    // Remove and return an element from the circular queue
    public int Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue Underflow: Nothing to dequeue.");
            return -1;
        }

        int item = queue[front];

        // If the queue has only one element left, reset pointers
        if (front == rear)
        {
            front = -1;
            rear = -1;
        }
        else
        {
            // Circularly increment the front pointer
            front = (front + 1) % maxSize;
        }

        Console.WriteLine($"Dequeued: {item}");
        return item;
    }

    // Display all active elements in the queue
    public void Display()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty.");
            return;
        }

        Console.Write("Queue elements: ");
        int i = front;
        while (true)
        {
            Console.Write(queue[i] + " ");
            if (i == rear) 
                break;
            
            i = (i + 1) % maxSize; // Wrap around safely
        }
        Console.WriteLine();
    }
}

// Program to test the Circular Queue
class Program
{
    static void Main()
    {
        CircularQueue cq = new CircularQueue(5);

        cq.Enqueue(10);
        cq.Enqueue(20);
        cq.Enqueue(30);
        cq.Enqueue(40);
        cq.Enqueue(50);
        cq.Display(); // Output: 10 20 30 40 50

        cq.Enqueue(60); // Queue Overflow

        cq.Dequeue();
        cq.Dequeue();
        cq.Display(); // Output: 30 40 50

        Console.WriteLine("\n--- Reusing the freed up slots ---");
        cq.Enqueue(60);
        cq.Enqueue(70);
        cq.Display(); // Output: 30 40 50 60 70
    }
}