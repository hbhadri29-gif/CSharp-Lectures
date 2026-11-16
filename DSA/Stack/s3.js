using System;
public class Stack
{
    private int[] items; 
    private int top; 
    
    public Stack(int size)
    {
        items = new int[size]; 
        top = -1;              
    }
    
    public bool IsEmpty()
    {
        return top == -1; 
    }
    
    public bool IsFull()
    {
        return top == items.Length - 1;  
    }
    
    public void Push(int item)
    {
        if (IsFull())
        {
            Console.WriteLine("Stack Full!"); 
            return;
        }
        items[++top] = item; 
    }
    
    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack underflow"); 
            return -1;
        }
        return items[top--]; 
    }
    
    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }
        return items[top];
    }
    
    public static void Display(Stack stack)
    {
        if (stack.IsEmpty())
        {
            Console.WriteLine("Stack is empty"); 
            return;
        }
        Console.WriteLine("\nStack elements:");
        for (int i = stack.top; i >= 0; i--)
        {
            Console.Write(stack.items[i] + " "); 
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Initialize a stack:");
        Stack stack = new Stack(5); 
        Console.WriteLine("Checking if stack is empty: " + stack.IsEmpty());
        Console.WriteLine("\nInput some elements onto the stack:");
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Push(50);
        Stack.Display(stack); 
        Console.WriteLine("\nTop element of the stack: " + stack.Peek());
        Console.WriteLine("\nChecking if stack is full: " + stack.IsFull());
        Console.WriteLine("\nPopping three elements from the stack:");
        Console.WriteLine(stack.Pop()); 
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Stack.Display(stack); 
        Console.WriteLine("\nTop element of the stack: " + stack.Peek()); 
    }
}