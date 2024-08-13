using Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Queue;
using Data_Structures_and_Algorithms_CSharp.Scripts.Utils;

namespace Data_Structures_and_Algorithms_CSharp.Scripts.Tests.Data_Structures.Queue;

public static class DefaultQueueTest
{
    public static void Test()
    {
        var queue = new DefaultQueue<int>(4);

        ConsoleUtility.PrintHyphens();
        queue.PrintCurrentStack();
        ConsoleUtility.PrintHyphens();
        
        var peekResult = queue.Peek();
        Console.WriteLine($"Peek: {peekResult}");
        queue.PrintCurrentStack();
        ConsoleUtility.PrintHyphens();
        
        var dequeueResult = queue.Dequeue();
        Console.WriteLine($"Dequeue: {dequeueResult}");
        queue.PrintCurrentStack();
        ConsoleUtility.PrintHyphens();
        
        queue.Enqueue(1);
        Console.WriteLine($"Enqueue 1");
        queue.PrintCurrentStack();
        ConsoleUtility.PrintHyphens();

        peekResult = queue.Peek();
        Console.WriteLine($"Peek: {peekResult}");
        queue.PrintCurrentStack();
        ConsoleUtility.PrintHyphens();
        
        queue.Enqueue(2);
        Console.WriteLine($"Enqueue 2");
        queue.PrintCurrentStack();
        ConsoleUtility.PrintHyphens();
        
        queue.Enqueue(3);
        Console.WriteLine($"Enqueue 3");
        queue.PrintCurrentStack();
        ConsoleUtility.PrintHyphens();
        
        dequeueResult = queue.Dequeue();
        Console.WriteLine($"Pop: {dequeueResult}");
        queue.PrintCurrentStack();
        ConsoleUtility.PrintHyphens();
        
        queue.Enqueue(4);
        Console.WriteLine($"Enqueue 4");
        queue.PrintCurrentStack();
        ConsoleUtility.PrintHyphens();
        
        queue.Enqueue(5);
        Console.WriteLine($"Enqueue 5");
        queue.PrintCurrentStack();
        ConsoleUtility.PrintHyphens();
        
        queue.Enqueue(6);
        Console.WriteLine($"Enqueue 6");
        queue.PrintCurrentStack();
        ConsoleUtility.PrintHyphens();
    }
}