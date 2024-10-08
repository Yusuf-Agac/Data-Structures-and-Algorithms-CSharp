﻿using Data_Structures_and_Algorithms_CSharp.Scripts.Utils;

namespace Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Stack;

public class Stack<T>(int capacity)
{
    private readonly T?[] _array = new T?[capacity];
    private int _topIndex = -1;

    public bool IsEmpty => _topIndex <= -1;
    public bool IsFull => _topIndex >= _array.LastIndex();
    
    public T? Peek()
    {
        if(IsEmpty) Console.WriteLine("Queue is not valid for Peek");
        return IsEmpty ? default : _array[_topIndex];
    }

    public void Push(T? item)
    {
        if (IsValidForPush())
        {
            _topIndex++;
            _array[_topIndex] = item;
            return;
        }
        Console.WriteLine("Stack is not valid for Push");
    }
    
    public T? Pop()
    {
        if (IsValidForPop())
        {
            var result = _array[_topIndex];
            _array[_topIndex] = default;
            _topIndex--;
            return result;
        }
        Console.WriteLine("Stack is not valid for Pop");
        return default;
    }
    
    public void Print()
    {
        Console.Write("Current Stack: ");
        foreach (var item in _array) Console.Write($"{item.ToString()}, ");
        ConsoleUtility.NextLine();
        Console.WriteLine($"TopIndex: {_topIndex}");
    }

    private bool IsValidForPush()
    {
        return !IsFull;
    }

    private bool IsValidForPop()
    {
        return !IsEmpty;
    }
}