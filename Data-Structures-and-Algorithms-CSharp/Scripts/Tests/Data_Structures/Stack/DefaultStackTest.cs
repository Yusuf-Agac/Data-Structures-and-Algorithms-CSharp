using Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Stack;
using Data_Structures_and_Algorithms_CSharp.Scripts.Utils;

namespace Data_Structures_and_Algorithms_CSharp.Scripts.Tests.Data_Structures.Stack;

public static class DefaultStackTest
{
    public static void Test()
    {
        var stack = new DefaultStack<int>(4);

        ConsoleUtility.PrintHyphens();
        stack.PrintCurrentStack();
        ConsoleUtility.PrintHyphens();
        
        var peekResult = stack.Peek();
        Console.WriteLine($"Peek: {peekResult}");
        stack.PrintCurrentStack();
        ConsoleUtility.PrintHyphens();
        
        var popResult = stack.Pop();
        Console.WriteLine($"Pop: {popResult}");
        stack.PrintCurrentStack();
        ConsoleUtility.PrintHyphens();
        
        stack.Push(1);
        Console.WriteLine($"Push 1");
        stack.PrintCurrentStack();
        ConsoleUtility.PrintHyphens();

        peekResult = stack.Peek();
        Console.WriteLine($"Peek: {peekResult}");
        stack.PrintCurrentStack();
        ConsoleUtility.PrintHyphens();
        
        stack.Push(2);
        Console.WriteLine($"Push 2");
        stack.PrintCurrentStack();
        ConsoleUtility.PrintHyphens();
        
        stack.Push(3);
        Console.WriteLine($"Push 3");
        stack.PrintCurrentStack();
        ConsoleUtility.PrintHyphens();
        
        popResult = stack.Pop();
        Console.WriteLine($"Pop: {popResult}");
        stack.PrintCurrentStack();
        ConsoleUtility.PrintHyphens();
        
        stack.Push(4);
        Console.WriteLine($"Push 4");
        stack.PrintCurrentStack();
        ConsoleUtility.PrintHyphens();
        
        stack.Push(5);
        Console.WriteLine($"Push 5");
        stack.PrintCurrentStack();
        ConsoleUtility.PrintHyphens();
        
        stack.Push(6);
        Console.WriteLine($"Push 6");
        stack.PrintCurrentStack();
        ConsoleUtility.PrintHyphens();
    }
}