﻿using System;

class MyStack<T>
{
    T[] StackArray;
    int StackPointer = 0;

    public void push(T x)
    {
        if (!IsStackFull)
        {
            StackArray[StackPointer++] = x;
        }
    }

    public T pop()
    {
        return (!IsStackEmpty)
          ? StackArray[--StackPointer] : StackArray[0];



    }
    const int MaxStack = 10;
    bool IsStackFull { get { return StackPointer >= MaxStack; } }
    bool IsStackEmpty { get { return StackPointer <= 0; } }

    public MyStack()
    {
        StackArray = new T[MaxStack];
    }
    
    public void Print()
    {
        for (int i = StackPointer - 1; i >= 0; i--)
            Console.WriteLine("Value : {StackArray[i]}");
    }

}

class Program
{
    static void Main()
    {
        MyStack<int> StackInt = new MyStack<int>();
        MyStack<string> StackString = new MyStack<string>();

        StackInt.push(3);
        StackInt.push(5);
        StackInt.push(7);
        StackInt.push(9);
        StackInt.Print();

        StackString.push("This is fun");
        StackString.push("Hi there!");
        StackString.Print();

    }
}

