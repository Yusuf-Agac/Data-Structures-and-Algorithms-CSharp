using Data_Structures_and_Algorithms_CSharp.Scripts.Implementations.Data_Structures.Queue;
using Data_Structures_and_Algorithms_CSharp.Scripts.Utils;

namespace Data_Structures_and_Algorithms_CSharp.Scripts.Tests.Data_Structures.Queue;

public static class QueueTest
{
    public static void Test()
    {
        var queue = new Implementations.Data_Structures.Queue.Queue<int>(4);

        ConsoleUtility.PrintHyphens();
        queue.Print();
        ConsoleUtility.PrintHyphens();
        
        var peekResult = queue.Peek();
        Console.WriteLine($"Peek: {peekResult}");
        queue.Print();
        ConsoleUtility.PrintHyphens();
        
        var dequeueResult = queue.Dequeue();
        Console.WriteLine($"Dequeue: {dequeueResult}");
        queue.Print();
        ConsoleUtility.PrintHyphens();
        
        queue.Enqueue(1);
        Console.WriteLine($"Enqueue 1");
        queue.Print();
        ConsoleUtility.PrintHyphens();

        peekResult = queue.Peek();
        Console.WriteLine($"Peek: {peekResult}");
        queue.Print();
        ConsoleUtility.PrintHyphens();
        
        queue.Enqueue(2);
        Console.WriteLine($"Enqueue 2");
        queue.Print();
        ConsoleUtility.PrintHyphens();
        
        queue.Enqueue(3);
        Console.WriteLine($"Enqueue 3");
        queue.Print();
        ConsoleUtility.PrintHyphens();
        
        dequeueResult = queue.Dequeue();
        Console.WriteLine($"Pop: {dequeueResult}");
        queue.Print();
        ConsoleUtility.PrintHyphens();
        
        queue.Enqueue(4);
        Console.WriteLine($"Enqueue 4");
        queue.Print();
        ConsoleUtility.PrintHyphens();
        
        queue.Enqueue(5);
        Console.WriteLine($"Enqueue 5");
        queue.Print();
        ConsoleUtility.PrintHyphens();
        
        queue.Enqueue(6);
        Console.WriteLine($"Enqueue 6");
        queue.Print();
        ConsoleUtility.PrintHyphens();
    }
}