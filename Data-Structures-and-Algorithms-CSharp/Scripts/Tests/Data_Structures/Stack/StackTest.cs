﻿using Data_Structures_and_Algorithms_CSharp.Scripts.Utils;

namespace Data_Structures_and_Algorithms_CSharp.Scripts.Tests.Data_Structures.Stack;

public static class StackTest
{
    public static void Test()
    {
        var stack = new Implementations.Data_Structures.Stack.Stack<int>(4);

        ConsoleUtility.PrintHyphens();
        stack.Print();
        ConsoleUtility.PrintHyphens();
        
        var peekResult = stack.Peek();
        Console.WriteLine($"Peek: {peekResult}");
        stack.Print();
        ConsoleUtility.PrintHyphens();
        
        var popResult = stack.Pop();
        Console.WriteLine($"Pop: {popResult}");
        stack.Print();
        ConsoleUtility.PrintHyphens();
        
        stack.Push(1);
        Console.WriteLine($"Push 1");
        stack.Print();
        ConsoleUtility.PrintHyphens();

        peekResult = stack.Peek();
        Console.WriteLine($"Peek: {peekResult}");
        stack.Print();
        ConsoleUtility.PrintHyphens();
        
        stack.Push(2);
        Console.WriteLine($"Push 2");
        stack.Print();
        ConsoleUtility.PrintHyphens();
        
        stack.Push(3);
        Console.WriteLine($"Push 3");
        stack.Print();
        ConsoleUtility.PrintHyphens();
        
        popResult = stack.Pop();
        Console.WriteLine($"Pop: {popResult}");
        stack.Print();
        ConsoleUtility.PrintHyphens();
        
        stack.Push(4);
        Console.WriteLine($"Push 4");
        stack.Print();
        ConsoleUtility.PrintHyphens();
        
        stack.Push(5);
        Console.WriteLine($"Push 5");
        stack.Print();
        ConsoleUtility.PrintHyphens();
        
        stack.Push(6);
        Console.WriteLine($"Push 6");
        stack.Print();
        ConsoleUtility.PrintHyphens();
    }
}